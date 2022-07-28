using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using UnityEngine;

namespace LB.RAFTS
{
    public class Rafts : MonoBehaviour
    {
        public List<Step> InitSteps = new List<Step>();
        public List<Step> MenuSteps = new List<Step>();
        
        public ILookup<string,Step> StepsByMenuGroup { get; private set; }

        private async Task OnEnable()
        {
            if (!isActiveAndEnabled)
                return;
                
            InitSteps.Clear();
            MenuSteps.Clear();
        
            var components = this.transform.GetComponentsInChildren<MonoBehaviour>(includeInactive:false);

            foreach (var component in components)
            {
                var type           = component.GetType();
                
                var properties     = type.GetProperties(BindingFlags.Public | BindingFlags.Instance).ToList();
                var stepProperties = properties.Where(p => p.PropertyType == typeof(Step)).ToList();
                var steps          = stepProperties.Select(p => p.GetValue(component) as Step).ToList();
                var initSteps      = steps.Where(s => s.Tags.ToLower().Contains("init")).ToList();
                var menuSteps      = steps.Where(s => s.Tags.ToLower().Contains("menu")).ToList();

                foreach (var menuStep in menuSteps)
                {
                    menuStep.Extra["MenuGroup"] = type.Name;
                }
                
                InitSteps.AddRange(initSteps);
                MenuSteps.AddRange(menuSteps);
            }
            
            PopulateStepsByMenuGroups();

            // Initialize
            
            Debug.Log("Rafts.Init - Start ------------------------------------");

            foreach (var initStep in InitSteps)
            {
                await initStep.Execute();
            }
            
            Debug.Log("Rafts.Init - Done ------------------------------------");
        }
        
        
        //// Helper
        
        
        void PopulateStepsByMenuGroups()
        {
            var stepsByMenuGroup = MenuSteps.ToLookup(x => x.Extra.GetValueOrDefault("MenuGroup", "General").ToString());
            
            this.StepsByMenuGroup = stepsByMenuGroup;
        }


        /////
        
        public Step Init  => new Step("Rafts-Init", "init", s => {s.Log("INIT");});
        public Step Menu  => new Step("Rafts-Menu", "menu", s => {s.Log("Menu");});
        
    }
}
