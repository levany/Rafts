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
    public partial class C_Slices_002_Full : CCore
    {
        // Menu Item
        
        #if UNITY_EDITOR
        [MenuItem("Rafts/_CRITICAL/2_Slices/002_Full")]
        #endif
        public static void Run()
        {   
            CFW.Run(new C_Slices_002_Full());
        }
        
        // Members
        
        Entity WIP;

        // CTOR
        
        public C_Slices_002_Full()
        {
            WIP = new Entity();
        }
        
        // CRITICAL STEPS
     
        public CStep __Full_Slice => new CStep();
 
        public CStep Scenario
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
        public CStep Scenarios
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
        
        public CStep Flow
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
        
        public CStep Product
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
    }
}
