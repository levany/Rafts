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
    public partial class C_Elements_Pipe : CCore
    {
        // Menu Item
        
        #if UNITY_EDITOR
        [MenuItem("Rafts/_CRITICAL/4_Elements/1_Pipe")]
        #endif
        public static void Run()
        {   
            CFW.Run(new C_Elements_Pipe());
        }
        
        // Members
        
        Entity WIP;

        // CTOR
        
        public C_Elements_Pipe()
        {
            WIP = new Entity();
        }
        
        // CRITICAL STEPS
     
        public CStep __Pipe => new CStep();
 
        public CStep CMD
            =>
                new CStep()
                .NOTE
                (
                     "[ ] Open Unity From CMD with params"
                    ,"[ ] Run open method"
                )
                .TASK(async s =>
                {   
                });
                
        public CStep ENV
            =>
                new CStep()
                .NOTE
                (
                     "[ ] Open Unity From CMD with params"
                    ,"[ ] Run open method"
                )
                .TASK(async s =>
                {   
                });
        
        public CStep SessionEvents
            =>
                new CStep()
                .NOTE
                (
                     "[ ] Editor Awake"
                    ,"[ ] Editor Start"
                    ,"[ ] Editor close"
                )
                .TASK(async s =>
                {   
                });
                
        public CStep Compile
            =>
                new CStep()
                .NOTE
                (
                     "[ ] pre-compile"
                    ,"[ ] post-compile"
                )
                .TASK(async s =>
                {   
                });
                
        public CStep T4
            =>
                new CStep()
                .NOTE
                (
                     "[ ] generate"
                )
                .TASK(async s =>
                {   
                });
                
        public CStep Import
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
        
        public CStep Scene
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
        public CStep Prefab
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
        public CStep Build
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
        public CStep Export
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
        public CStep Sync
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
        public CStep Config
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
        public CStep Play
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
        public CStep RUN
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
        public CStep Tests
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
        public CStep Bridge
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
    }
}
