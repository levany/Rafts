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
    public partial class C_Platform_2_Full : CCore
    {
        // Menu Item
        
        #if UNITY_EDITOR
        [MenuItem("Rafts/_CRITICAL/1_Platform/2_Full")]
        #endif
        public static void Run()
        {   
            CFW.Run(new C_Platform_2_Full());
        }
        
        // Members
        
        Entity WIP;

        // CTOR
        
        public C_Platform_2_Full()
        {
            WIP = new Entity();
        }
        
        // CRITICAL STEPS
     
        public CStep __Full => new CStep();
 
        public CStep TBD
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
    }
}
