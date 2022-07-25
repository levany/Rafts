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
    public partial class C_Platform_3_Sanity : CCore
    {
        // Menu Item
        
        #if UNITY_EDITOR
        [MenuItem("Rafts/CRITICAL/1_Platform/3_Sanity")]
        #endif
        public static void Run()
        {   
            CFW.Run(new C_Platform_3_Sanity());
        }
        
        // Members
        
        Entity WIP;

        // CTOR
        
        public C_Platform_3_Sanity()
        {
            WIP = new Entity();
        }
        
        // CRITICAL STEPS
     
        public CStep __Full => new CStep();
 
        public CStep BTN1
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
    }
}
