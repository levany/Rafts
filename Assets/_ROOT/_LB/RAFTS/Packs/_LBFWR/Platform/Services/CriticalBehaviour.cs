using System;
using System.Threading.Tasks;
using UnityEngine;

namespace LB.RAFTS
{
    public class CriticalBehaviour : MonoBehaviour
    {
        public virtual Step Init 
        => 
            new Step
            (
                name   : GetType().Name + ".Init",
                tags   : "init",
                action : async s =>
                {
                    if (!isActiveAndEnabled)
                        return;
                
                    await OnInit(s);
                }
            );
            
        public virtual async Task OnInit(Step s)
        {
            // Override me
        } 
    }
}