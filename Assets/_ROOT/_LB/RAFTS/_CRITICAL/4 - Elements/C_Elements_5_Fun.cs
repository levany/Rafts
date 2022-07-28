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
    public partial class C_Elements_5_Fun : CCore
    {
        // Menu Item
        
        #if UNITY_EDITOR
        [MenuItem("Rafts/_CRITICAL/4_Elements/5_Fun")]
        #endif
        public static void Run()
        {   
            CFW.Run(new C_Elements_5_Fun());
        }
        
        // Members
        
        Entity WIP;

        // CTOR
        
        public C_Elements_5_Fun()
        {
            WIP = new Entity();
        }
        
        // CRITICAL STEPS
     
        public CStep ___Fun => new CStep();
        
        public CStep __Platformer => new CStep();
             
        public CStep Hero
            =>
                new CStep()
                .NOTE
                (
                    "Movement"
                    ,"[ ] Basic"
                    ,"      [ ] Walk"
                    ,"      [ ] Run"
                    ,"      [ ] Crouch"
                    ,"[ ] Jumping"
                    ,"      [ ] Jump"
                    ,"      [ ] x2"
                    ,"      [ ] x3"
                    ,"      [ ] High"
                    ,"      [ ] Glide"
                    ,"      [ ] Stomp"
                    ,"[ ] Dashing"
                    ,"      [ ] Dash"
                    ,"      [ ] Slide"
                    ,"      [ ] Warp (quick tp)"
                    ,"      [ ] Smoke"
                    ,"[ ] Down"
                    ,"      [ ] Dig"
                    ,"      [ ] Swim"
                    ,"[ ] Shadow"
                    ,"      [ ] TBD"
                )
                .TASK(async s =>
                {
                    // Hero
                })
                .NOTE
                (
                    "Mascot"
                    ,"      [ ] Ball"
                    ,"      [ ] Bouncy"
                    ,"      [ ] Tiny wings"
                    ,"      [ ] Fluid movement"
                )
                .TASK(async s =>
                {
                    
                })
                .NOTE
                (
                    "Melee - TBD"
                )
                .TASK(async s =>
                { 
                  
                })
                .NOTE
                (
                    "Melee-Weapons"
                   ,"[ ] Sword"
                   ,"   [ ] Base"
                   ,"       [ ] Slash"
                   ,"       [ ] 3-combo"
                   ,"       [ ] Endless"
                   ,"   [ ] Strong"
                   ,"       [ ] Strong slash"
                   ,"   [ ] Ground"
                   ,"       [ ] Uppercut"
                   ,"   [ ] Air"
                   ,"       [ ] Down-cut"
                   ,"       [ ] Stomp"
                )
                .TASK(async s =>
                {   
                    
                })
                .NOTE
                (
                    "Tech-Weapons"
                   ,"[ ] Gun"
                   ,"   [ ] Tap  - Shotgun"
                   ,"   [ ] Hold - MachineGun"
                )
                .TASK(async s =>
                {   
                    
                })
                .NOTE
                (
                    "Magic"
                   ,"[ ] Projectiles"
                   ,"   [ ] Taps - fireballs"
                   ,"   [ ] Hold - Big"
                )
                .TASK(async s =>
                {   
                    
                })
                .NOTE
                (
                    "Special"
                   ,"[ ] TC"
                   ,"[ ] TK"
                   ,"[ ] TO"
                   ,"[ ] TP"
                )
                .TASK(async s =>
                {   
                    
                })
                .NOTE
                (
                    "Companion"
                   ,"[ ] Wolf"
                )
                .TASK(async s =>
                {   
                    
                })
                .NOTE
                (
                    "Bus"
                   ,"[ ] Lights"
                   ,"[ ] Rockets"
                )
                .TASK(async s =>
                {   
                    
                })
                .NOTE
                (
                    "Nature"
                   ,"[ ] Flore"
                )
                .TASK(async s =>
                {   
                    
                });
                
        public CStep __Ptakim => new CStep();

        public CStep Ptakim
            =>
                new CStep()
                .NOTE
                (
                    "Ptakim"
                   ,"[ ] TBD"
                )
                .TASK(async s =>
                {   
                });
                
        public CStep __Kabu => new CStep();
                
        public CStep Kabu
            =>
                new CStep()
                .NOTE
                (
                    "KABU"
                   ,"[ ] Cards"
                   ,"   [ ] Card"
                   ,"   [ ] Deck"
                   ,"   [ ] Pile"
                   ,"   [ ] Slot"
                   ,"   [ ] Hand"
                   ,"   [ ] Table"
                   ,"   [ ] Player"
                   ,"[ ] Kabu"
                   ,"   [ ] Scenario-1 : Super-Simple-TBD"
                )
                .TASK(async s =>
                {   
                });
                
        public CStep __BoardGame => new CStep();
                
        public CStep BoardGame
            =>
                new CStep()
                .NOTE
                (
                    "Board-Game"
                   ,"[ ] Board"
                   ,"   [ ] Tile"
                   ,"   [ ] Piece"
                   ,"   [ ] Dice"
                   ,"   [ ] Cards"
                   ,"[ ] Lane"
                   ,"   [ ] Scenario-1 : Super-Simple-TBD"
                )
                .TASK(async s =>
                {   
                });
                
        public CStep __Basketball => new CStep();
                
        public CStep Basketball
            =>
                new CStep()
                .NOTE
                (
                    "Baskeetball"
                   ,"[ ] Movement"
                   ,"   [ ] Squash"
                   ,"   [ ] Fluid"
                   ,"   [ ] Bounce"
                   ,"   [ ] Stomp"
                )
                .TASK(async s =>
                {   
                });
                
        public CStep __Langs => new CStep();
                
        public CStep Langs
            =>
                new CStep()
                .NOTE
                (
                    "Langs"
                   ,"[ ] Vocabulary"
                   ,"   [ ] 1 -Person Do Thing"
                   ,"   [ ] 2 - TBD"
                   ,"[ ] Scenarios"
                   ,"   [ ] Pizza"
                   ,"   [ ] Hotel"
                   ,"   [ ] TBD"
                )
                .TASK(async s =>
                {   
                });
                
 
    }
}
