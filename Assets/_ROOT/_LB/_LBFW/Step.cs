using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RAFTS
{
    public class Step 
    {
        public string       Name;
        public string       Tags;
        public Action<Step> Action;

        public Step(string name, string tags = "", Action<Step> action = default)
        {
            this.Name   = name;
            this.Tags   = tags;
            this.Action = action;
        }   
        
        public void Execute()
        {
            Debug.Log($"[{this.Name}]");
            this.Action.Invoke(this);
        }
    }
}