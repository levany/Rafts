using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using LB.RAFTS;
using UnityEngine;

public class Ads : CriticalBehaviour
{
    // Lifecycle
    
    public override async Task OnInit(Step s)
    {   
    }

    // Menu Items

    public Step Interstitial 
    => 
        new Step(nameof(Interstitial),
                 "menu",
                 s =>
                 {
                     
                 });
                 
    public Step Rewarded 
    => 
        new Step(nameof(Rewarded),
                 "menu",
                 s =>
                 {
                     
                 });
                 
    public Step Banner 
    => 
        new Step(nameof(Banner),
                 "menu",
                 s =>
                 {
                     
                 });
    
}
