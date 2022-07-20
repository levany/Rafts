using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace LB.Rafts
{
    // Final Report
    public partial class CP : CCore
    {
        public CStep ___LBFWR => new CStep(); ////////////////////////////////////////////////////////////////////////// LBFWR
    
        public CStep LBFWR_Report
            =>
                new CStep()
                .NOTE
                (
                     "[ ] Entity"
                    ,"[ ]       ID"
                    ,"[ ]       Link"
                    ,"[ ]       Extra"
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
                    ,"[ ]       UI"
                    ,"[ ]       TreeView"
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
                .TASK("Report", async s =>
                {  
                   s.Log("Products Report"); 
                });
                
                
        public CStep ___Milestones => new CStep(); ///////////////////////////////////////////////////////////////////// Milestones
 
        public CStep Milestones
            =>
                new CStep()
                .NOTE
                (
                     "Bus"
                    ,"[ ]   Slice = tile"
                    ,"[ ]   Core "
                    ,"[ ]   BUS "
                )
                .NOTE
                (
                     "BBW"
                    ,"[ ]   Slice"
                    ,"[ ]   Prop = phase"
                )
                .TASK("Report", async s =>
                {  
                   s.Log("Milestones Report"); 
                });
                
                
        public CStep ___Flagship => new CStep(); /////////////////////////////////////////////////////////////////////// Flagship
 
        public CStep Flagship
            =>
                new CStep()
                .NOTE
                (
                     "FB"
                    ,"[ ] Slice"
                    ,"[ ] Core"
                    ,"[ ] Match"
                    ,"[ ] Line"
                    ,"[ ] Team"
                    ,"[ ] Campaign"
                )
                .TASK("Report", async s =>
                {  
                   s.Log("Flagship Report"); 
                });
                
                
        public CStep ___Rafts => new CStep(); ////////////////////////////////////////////////////////////////////////// Rafts
 
        public CStep Rafts
            =>
                new CStep()
                .NOTE
                (
                     "Rafts"
                    ,"[ ] 1"
                    ,"[ ] 2"
                    ,"[ ] 3"
                    ,"[ ] 4"
                    ,"[ ] 5"
                    ,"[ ] 6"
                )
                .TASK("Report", async s =>
                {  
                   s.Log("Rafts Report"); 
                });
                
        public CStep ___Critical => new CStep(); /////////////////////////////////////////////////////////////////////// Critical
 
        public CStep Critical
            =>
                new CStep()
                .NOTE
                (
                     "Critical report"
                    ,"[ ]   TBD"
                )
                .TASK("Report", async s =>
                {  
                   s.Log("Critical Report"); 
                });
    }
}