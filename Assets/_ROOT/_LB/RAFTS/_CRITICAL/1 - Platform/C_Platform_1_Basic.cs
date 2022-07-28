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
    public partial class C_Platform_1_Basic : CCore
    {
        // Menu Item
        
        #if UNITY_EDITOR
        [MenuItem("Rafts/_CRITICAL/1_Platform/1_Basic", false, 0)]
        #endif
        public static void Run()
        {   
            CFW.Run(new C_Platform_1_Basic());
        }
        
        // Members
        
        Entity WIP;

        // CTOR
        
        public C_Platform_1_Basic()
        {
            WIP = new Entity();
        }
        
        // CRITICAL STEPS
     
        public CStep __Basic => new CStep();
 
        public CStep TBD
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
    }
}
