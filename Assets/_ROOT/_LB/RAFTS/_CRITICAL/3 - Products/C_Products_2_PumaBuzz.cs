using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace LB.RAFTS
{
    // Final Report
    public partial class C_Products_2_PumaBuzz : CCore
    {
        // Menu Item
        
        #if UNITY_EDITOR
        [MenuItem("Rafts/_CRITICAL/3_Products/2_PumaBuzz")]
        #endif
        public static void Run()
        {   
            CFW.Run(new C_Products_2_PumaBuzz());
        }
        
        // Members
        
        Entity WIP;

        // CTOR
        
        public C_Products_2_PumaBuzz()
        {
            WIP = new Entity();
        }
        
        // CRITICAL STEPS
     
        public CStep __PumaBuzz => new CStep();
        
        public CStep Restyle 
        => 
            new CStep()
            .TASK(async s =>
            {
                
            });        
    }
}
