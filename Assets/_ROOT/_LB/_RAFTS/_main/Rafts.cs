using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace RAFTS
{
    public class Rafts : MonoBehaviour
    {
        public List<Step> MenuSteps = new List<Step>();
    
        private void Start_()
        {
            var components = this.transform.GetComponentsInChildren<MonoBehaviour>(includeInactive:true);

            foreach (var component in components)
            {
                var type = component.GetType();
                
                var properties     = type.GetProperties(BindingFlags.Public | BindingFlags.Instance).ToList();
                var stepProperties = properties.Where(p => p.PropertyType == typeof(Step)).ToList();
                var steps          = stepProperties.Select(p => p.GetValue(component) as Step).ToList();
                
                MenuSteps.AddRange(steps);
            }
        }

        ////

        private void OnGUI()
        {
            
            GUILayout.BeginVertical();
            
            GUILayout.Space(50);
            
        
            foreach (var menuStep in MenuSteps)
            {
                Button(menuStep);   
            }
            
            GUILayout.EndVertical();
            
        }
        
        public static bool Button(Step step)
        {
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            bool btn = GUILayout.Button(step.Name, GUILayout.Width(300), GUILayout.Height(40));
            
            if (btn)
            {
                step.Execute();
            }
            
            GUILayout.EndHorizontal();
            return btn;
        }
        
        /////
        
        public Step Menu => new Step("Menu", "", s => {});
        public Step Menu2 => new Step("Menu2");
        
    }
}
