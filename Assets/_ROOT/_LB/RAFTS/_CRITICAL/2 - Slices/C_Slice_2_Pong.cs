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
    public partial class C_Slice_2_Pong : CCore
    {
        // Menu Item
        
        #if UNITY_EDITOR
        [MenuItem("Rafts/_CRITICAL/2_Slices/2_Pong")]
        #endif
        public static void Run()
        {   
            CFW.Run(new C_Slice_2_Pong());
        }
        
        // Members
        
        Entity WIP;

        // CTOR
        
        public C_Slice_2_Pong()
        {
            WIP = new Entity();
        }
        
        // CRITICAL STEPS
     
        public CStep __Pong => new CStep();
 
        public CStep Slice
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
    }
}
