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
    public partial class C_Products_3_ButtonSmash : CCore
    {
        // Menu Item
        
        #if UNITY_EDITOR
        [MenuItem("Rafts/CRITICAL/3_Products/3_ButtonSmash")]
        #endif
        public static void Run()
        {   
            CFW.Run(new C_Products_3_ButtonSmash());
        }
        
        // Members
        
        Entity WIP;

        // CTOR
        
        public C_Products_3_ButtonSmash()
        {
            WIP = new Entity();
        }
        
        // CRITICAL STEPS
     
        public CStep __PumaBuzz => new CStep();
        
        public CStep Tweak 
        => 
            new CStep()
            .TASK(async s =>
            {
                
            });           
    }
}
