using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Object = System.Object;

namespace LB.RAFTS
{
    public class Step 
    {
        // Members
    
        public string           Name;
        public string           Tags;
        public Func<Step, Task> Action;
        
        public Dictionary<string, Object> Extra = new Dictionary<string, object>();

        // Creation

        public Step(string name, string tags = "", Func<Step, Task> action = default)
        {
            this.Name   = name;
            this.Tags   = tags;
            this.Action = action;
        }
        public Step(string name, string tags = "", Action<Step> action = default)
        {
            this.Name   = name;
            this.Tags   = tags;
            this.Action = (s) => { action.Invoke(s); return Task.CompletedTask; } ;
        }   
          
        // API
        
        public async Task Execute()
        {
            Debug.Log($"<color=white><b>[{this.Name}]</b></color>");
            await this.Action.Invoke(this);
        }
        
        // Methods
        
        public void Log(object message)
        {
            Debug.Log(message);
        }
    }
}