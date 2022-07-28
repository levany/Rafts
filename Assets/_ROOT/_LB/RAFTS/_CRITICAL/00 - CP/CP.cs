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
    public partial class CP : CCore
    {
        
        #if UNITY_EDITOR
        [MenuItem("Rafts/_CRITICAL/0_CP")]
        #endif
        public static void RunActionPath()
        {   
            CFW.Run(new CP());
        }
        
    
        public CStep ___LBFWR => new CStep(); ////////////////////////////////////////////////////////////////////////// LBFWR
    
        public CStep LBFWR
            =>
                new CStep()
                .NOTE
                (
                     "[ ] Entity"
                    ,"[ ]       ID"
                    ,"[ ]       Link"
                    ,"[ ]       Extra"
                    ,"[ ]       Init"
                    ,"[ ] Tree"
                    ,"[ ]       Root"
                    ,"[ ]       Home"
                    ,"[ ] Code"
                    ,"[ ]       Tools"
                    ,"[ ]       Action"
                    ,"[ ]       Step"
                    ,"[ ]       Flow"
                    ,"[ ]       Operation"
                    ,"[ ] Data"
                    ,"[ ]       Item"
                    ,"[ ] Asset"
                    ,"[ ]       Asset"
                    ,"[ ] Core"
                    ,"[ ]       Package"
                    ,"[ ]       Module"
                    ,"[ ]       Flow"
                    ,"[ ] UI"
                    ,"[ ]       Base"
                    ,"[ ]           UIE"
                    ,"[ ]           Screen"
                    ,"[ ]           Layout"
                    ,"[ ]           Style"
                    ,"[ ]       1"
                    ,"[ ]           Button"
                    ,"[ ]           Text"
                    ,"[ ]           Image"
                    ,"[ ]       Dev"
                    ,"[ ]           TreeView"
                )
                .TASK("Report", async s =>
                {   
                    s.Log("LBFWR Rerpot");
                });
                
        public CStep ___Platform => new CStep(); /////////////////////////////////////////////////////////////////////// Platform
         
        public CStep Platform
            =>
                new CStep()
                .NOTE
                (
                     " [ ] On Run CP : "
                    ,"      - Create and run following flow : "
                    ,"======================================== "
                    ,"[ ] Remote"
                    ,"[~]       UI"
                    ,"[~]       TreeView"
                    ,"[ ]       BE"
                    ,"[ ]       Sync"
                    ,"[ ] Product"
                    ,"[ ]       Info"
                    ,"[ ]       Meta"
                    ,"[ ]       PressKit"
                    ,"[ ]       Store"
                    ,"[ ]       Deploy"
                    ,"[ ] Pipe"
                    ,"[ ]       PrePipe"
                    ,"[ ]               PreBuild"
                    ,"[ ]               Build"
                    ,"[ ]               PostBuild"
                    ,"[ ]               PreExport"
                    ,"[ ]               PostExport"
                    ,"[ ]       PostPipe"
                    ,"[ ]       Artifacts"
                    ,"[ ]       Bridge"
                    ,"[ ] Live"
                    ,"[ ]       Setup"
                    ,"[ ]       Edit"
                    ,"[ ]       Sync"
                    ,"[ ]       .SO"
                    ,"[ ]       .Extra"
                    ,"[ ] Editor"
                    ,"[ ]       Session"
                    ,"[ ]               PreCompile"
                    ,"[ ]               PostCompile"
                    ,"[ ]               ETC"
                    ,"[ ]               Bridge"
                    ,"[ ]       Tools"
                    ,"[ ]               Paths"
                    ,"[ ]       Core"
                    ,"[ ]               Report"
                    ,"[ ]               Packages"
                    ,"[ ]               Assets"
                    ,"[ ] Container"
                    ,"[ ]           Report"
                    ,"[ ]                   Info"
                    ,"[ ]                   Source"
                    ,"[ ]                   Bridge-History"
                    ,"[ ]           Panel"
                    ,"[ ]                   Log"
                    ,"[ ]           Flow"
                    ,"[ ]                   Isolate"
                    ,"[ ]                   Main"
                    ,"[ ] App"
                    ,"[ ]       Flow"
                    ,"[ ]               System"
                    ,"[ ]               Core"
                    ,"[ ]       Mula"
                    ,"[ ]               Ads"
                    ,"[ ]                       1"
                    ,"[ ]                       2"
                    ,"[ ]                       3"
                    ,"[ ]               IAP"
                    ,"[ ]                       Scenarios"
                    ,"[ ]       Services"
                    ,"[ ]               Reports"
                    ,"[ ]                       Log"
                    ,"[ ]                       Crash"
                    ,"[ ]                       Analytics"
                    ,"[ ]               Unity"
                    ,"[ ]                       Auth"
                    ,"[ ]                       Config"
                    ,"[ ]                       Save"
                    ,"[ ]                       Code"
                    ,"[ ]               Elements"
                    ,"[ ]                       Accounts"
                    ,"[ ]                       Data"
                    ,"[ ] Core"
                    ,"[ ]       Structure"
                    ,"[ ]               Packages"
                    ,"[ ]               Assets"
                    ,"[ ]               Modules"
                    ,"[ ]               Runtime"
                    ,"[ ]       Flow"
                    ,"[ ]               Init"
                    ,"[ ]               Main"
                    ,"[ ] BTN-1"
                    ,"[ ]       Workflow"
                    ,"[ ]               Print"
                    ,"[ ]               Report"
                    ,"[ ]               Run"
                    ,"[ ]               Init"
                    ,"[ ]               Scenario"
                    ,"[ ]               Click"
                    ,"[ ]       Structure"
                    ,"[ ]               Package"
                    ,"[ ]               Module"
                    ,"[ ]               Screen"
                    ,"[ ]               Button"
                    ,"[ ]               Text"
                    ,"[ ]               Item"
                    ,"[ ]               OnClick()"
                    ,"[ ]               Transaction"
                )
                .TASK("Run Platform", async s =>
                {   
                    /// Run platform
                    ///
                    ///     Simulate the following :
                    /// 
                    ///     - open remote
                    ///     - click bank
                    ///     - add slice "BTN1"
                    ///     - Print
                    ///         - Create Product
                    ///         - Run pipe
                    ///         - Deploy
                    ///     - Live
                    ///         - Setup
                    ///         - Edit
                    ///     - Editor
                    ///         - Report
                    ///         - Core
                    ///         - Tools
                    ///         - Session
                    ///         - Edit
                    ///     - Run
                    ///     - Container
                    ///         - Report
                    ///         - QA
                    ///         - Isolate
                    ///             - Artifacts
                    ///             - Scenarios
                    ///         - Main
                    ///     - App
                    ///         - Report
                    ///         - Mula
                    ///         - User
                    ///         - Servicrs
                    ///     - Core
                    ///         - Report
                    ///     - BTN1
                    ///         - Report
                    ///         - Click
                    ///         - Results
                })
                .TASK("Report", async s =>
                {  
                   s.Log("Slices Report"); 
                });


        public CStep ___Sclices => new CStep(); //////////////////////////////////////////////////////////////////////// Slices

 
        public CStep Slice
            =>
                new CStep()
                .NOTE
                (
                     "Slices"
                    ,"[ ]       Scene"
                    ,"[ ]               Systems"
                    ,"[ ]                       Camera"
                    ,"[ ]                       Lighting"
                    ,"[ ]                       Rendering"
                    ,"[ ]                       Audio"
                    ,"[ ]                       Input"
                    ,"[ ]                       ETC"
                    ,"[ ]       SliceBlock"
                    ,"[ ]               Screen"
                    ,"[ ]               HUD"
                    ,"[ ]               3D"
                    ,"[ ]               2D"
                    ,"[ ]       PROP"
                    ,"[ ]               Code"
                    ,"[ ]                       Entity"
                    ,"[ ]                       :Motor"
                    ,"[ ]                       Controller?"
                    ,"[ ]                       Behaviour"
                    ,"[ ]               Model"
                    ,"[ ]                       3D"
                    ,"[ ]                           Mesh"
                    ,"[ ]                           Material"
                    ,"[ ]                           Texture"
                    ,"[ ]                       2D"
                    ,"[ ]                           Sprite"
                    ,"[ ]               Animation"
                    ,"[ ]                       Clip"
                    ,"[ ]                           Properties"
                    ,"[ ]                           Keyframes"
                    ,"[ ]                                   Values"
                    ,"[ ]                       Simple"
                    ,"[ ]                       Animator"
                    ,"[ ]                       Timeline"
                    ,"[ ]               Audio"
                    ,"[ ]                       Clip"
                    ,"[ ]                       Wrapper"
                    ,"[ ]       System"
                    ,"[ ]               Code"
                    ,"[ ]               Events"
                    ,"[ ]               Cues"
                    ,"[ ]               Actions"
                    ,"[ ]               Steps"
                    ,"[ ]               Items"
                    ,"[ ]       Scenario"
                    ,"[ ]               Setup"
                    ,"[ ]               Deterministic"
                    ,"[ ]               Flow"
                    ,"[ ]               Bridge"
                    ,"[ ]       Scenarios"
                    ,"[ ]               Solo"
                    ,"[ ]               Interactions"
                    ,"[ ]               Sanity ('hi')" 
                    ,"[ ]               CP"
                    ,"[ ]               Coverage"
                    ,"[ ]       Core"
                    ,"[ ]               Setup"
                    ,"[ ]               Flow"
                    ,"[ ]       PANDA"
                    ,"[ ]               Panda prop"
                    ,"[ ]               Panda Place"
                    ,"[ ]               Panda Flow"
                )
                .NOTE
                (
                     "Slices Results"
                    ,"[ ]       Dino"
                    ,"[ ]               2D   - Desert"
                    ,"[ ]               PROP - Dino"
                    ,"[ ]               PROP - Cactus"
                    ,"[ ]               PROP - Bird"
                    ,"[ ]               Core - gameplay"
                    ,"[ ]               System - Boom"
                    ,"[ ]               System - Score"
                    ,"[ ]       Pong"
                    ,"[ ]               Prop - Ball"
                    ,"[ ]               Prop - Block"
                    ,"[ ]               Prop - Region"
                    ,"[ ]               HUD  - Score"
                    ,"[ ]               Core - Gameplay"
                    ,"[ ]               System - Boom"
                    ,"[ ]               System - Score"
                    ,"[ ]       Tennis"
                    ,"[ ]               TBD"
                    ,"[ ]       Other"
                    ,"[ ]               TBD"
                )
                .NOTE
                (
                     "MIX - Tennis-Pong"
                    ,"[ ]       TBD"
                )
                .TASK("Run Slices", async s =>
                {   
                    /// Run Slices
                    ///
                    ///     Simulate the following :
                    /// 
                    ///     - open remote
                    ///     - click bank
                    ///     - add slice "PANDA"
                    ///     - Print
                    ///         - Create Slice
                    /// 
                    ///     - add slice "Dino"
                    ///     - add slice "Pong"
                    ///     - add slice "Tennis"
                    ///     - add slice "Other"
                })
                .TASK("Report", async s =>
                {  
                   s.Log("Slices Report"); 
                });
                
        public CStep ___Products => new CStep(); /////////////////////////////////////////////////////////////////////// Products
 
        public CStep Products
            =>
                new CStep()
                .NOTE
                (
                    "Panda-Buzz"
                    ,"[ ]       Assets"
                    ,"[ ]               UI"
                    ,"[ ]               Scene"
                    ,"[ ]       Core"
                    ,"[ ]       Match"
                    ,"[ ]       Line"
                    ,"[ ]       Team"
                    ,"[ ]       Campaign"
                )
                .NOTE
                (
                     "Puma-Buzz"
                    ,"[ ]       Re-Skin"
                    ,"[ ]       Re-Repackage"
                )
                .NOTE
                (
                     "button-Smash"
                    ,"[ ]       Re-System"
                    ,"[ ]       Re-Skin"
                    ,"[ ]       Re-Package"
                )
                .TASK("Run Products", async s =>
                {   
                    /// Run Products
                    ///
                    ///     Simulate the following :
                    /// 
                    ///     - Run Panda-Buzz    + Report
                    ///     - Run Puma-Buzz     + Report
                    ///     - Run Button-Smash  + Report
                })
                .TASK("Report", async s =>
                {  
                   s.Log("Products Report"); 
                });
    }
}
