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
    public partial class C_Elements_3_Presskit : CCore
    {
        // Menu Item
        
        #if UNITY_EDITOR
        [MenuItem("Rafts/_CRITICAL/4_Elements/3_Presskit")]
        #endif
        public static void Run()
        {   
            CFW.Run(new C_Elements_3_Presskit());
        }
        
        // Members
        
        Entity WIP;

        // CTOR
        
        public C_Elements_3_Presskit()
        {
            WIP = new Entity();
        }
        
        // CRITICAL STEPS
     
        public CStep __Presskit_Runtime => new CStep()
        .NOTE
        (
            "[~] Runtime Screenshot"
           ,"[ ] Runtime Gif"
           ,"[ ] Runtime Video"
        );
 
        public CStep Runtime_Screenshot
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
        public CStep Runtime_GIF
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
                
        public CStep Runtime_Video
            =>
                new CStep()
                .TASK(async s =>
                {   
                });
    }
}
