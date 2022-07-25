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
    public partial class C_Elements_Extentions : CCore
    {
        // Menu Item
        
        #if UNITY_EDITOR
        [MenuItem("Rafts/CRITICAL/4_Elements/2_Extensions")]
        #endif
        public static void Run()
        {   
            CFW.Run(new C_Elements_Extentions());
        }
        
        // Members
        
        Entity WIP;

        // CTOR
        
        public C_Elements_Extentions()
        {
            WIP = new Entity();
        }
        
        // CRITICAL STEPS
     
        public CStep __Extentions => new CStep();
 
        public CStep Editor_Window
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
        public CStep Inspector
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                                
        public CStep Property
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                   
        public CStep ContextMenu
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                                   
        public CStep Gizmo
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                                
        public CStep Handles
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
        public CStep Editor_Layout
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
        public CStep Scriptable_Object
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
        public CStep EditorScript
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
        
        public CStep Runtime_Object
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
        
        public CStep Mix_Script
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
        
        public CStep Rafts_Quick_Tree
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
        
        public CStep Scene_Tools
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
    }
}
