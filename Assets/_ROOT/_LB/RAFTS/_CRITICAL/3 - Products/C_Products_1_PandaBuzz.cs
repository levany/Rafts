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
    public partial class C_Products_1_PandaBuzz : CCore
    {
        // Menu Item
        
        #if UNITY_EDITOR
        [MenuItem("Rafts/CRITICAL/3_Products/1_Pipe")]
        #endif
        public static void Run()
        {   
            CFW.Run(new C_Products_1_PandaBuzz());
        }
        
        // Members
        
        Entity WIP;

        // CTOR
        
        public C_Products_1_PandaBuzz()
        {
            WIP = new Entity();
        }
        
        // CRITICAL STEPS
     
        public CStep __PandaBuzz => new CStep();
 
        public CStep Match
            =>
                new CStep()
                .NOTE
                (
                     "[~] Assets"
                    ,"[ ] UI"
                    ,"[ ] Gameplay"
                )
                .TASK(async s =>
                {   
                });
                
        public CStep Line
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
        public CStep Team
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
        
                
        
                
    }
}
