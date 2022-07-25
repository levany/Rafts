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
    public partial class C_Elements_4_Debug : CCore
    {
        // Menu Item
        
        #if UNITY_EDITOR
        [MenuItem("Rafts/CRITICAL/4_Elements/4_Debug")]
        #endif
        public static void Run()
        {   
            CFW.Run(new C_Elements_4_Debug());
        }
        
        // Members
        
        Entity WIP;

        // CTOR
        
        public C_Elements_4_Debug()
        {
            WIP = new Entity();
        }
        
        // CRITICAL STEPS
     
        public CStep __Debug => new CStep();
 
        public CStep Dump
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
        public CStep Profiler
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
        public CStep Memory_Profiler
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                        
        public CStep Frame_Debugger
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
        
                        
        public CStep Log
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                

        public CStep Source
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
                
        public CStep TBD
            =>
                new CStep()
                .NOTE
                (
                     "[ ] TBD 1"
                    ,"[ ] TBD 2"
                )
                .TASK(async s =>
                {   
                });
 
    }
}
