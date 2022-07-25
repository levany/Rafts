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
    public partial class C_Slices_001_Basic : CCore
    {
        // Menu Item
        
        #if UNITY_EDITOR
        [MenuItem("Rafts/CRITICAL/2_Slices/001_Basic")]
        #endif
        public static void Run()
        {   
            CFW.Run(new C_Slices_001_Basic());
        }
        
        // Members
        
        Entity WIP;

        // CTOR
        
        public C_Slices_001_Basic()
        {
            WIP = new Entity();
        }
        
        // CRITICAL STEPS
     
        public CStep __Basic_Slice => new CStep();
 
        public CStep Block
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
            
        public CStep Prop
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
        
        public CStep Data
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
        
        public CStep System
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
            
                
    }
}
