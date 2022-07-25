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
    public partial class C_Slice_Mix_1_TennisPong : CCore
    {
        // Menu Item
        
        #if UNITY_EDITOR
        [MenuItem("Rafts/CRITICAL/2_Slices/Mix_1_TennisPong")]
        #endif
        public static void Run()
        {   
            CFW.Run(new C_Slice_Mix_1_TennisPong());
        }
        
        // Members
        
        Entity WIP;

        // CTOR
        
        public C_Slice_Mix_1_TennisPong()
        {
            WIP = new Entity();
        }
        
        // CRITICAL STEPS
     
        public CStep __TennisPong => new CStep();
 
        public CStep Slice
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
    }
}
