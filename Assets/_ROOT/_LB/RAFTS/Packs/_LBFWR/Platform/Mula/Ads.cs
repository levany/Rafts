using System.Collections;
using System.Collections.Generic;
using LB.RAFTS;
using UnityEngine;

public class Ads : MonoBehaviour
{
    public Step Interstitial 
    => 
        new Step(nameof(Interstitial),
                 "",
                 s =>
                 {
                     
                 });
                 
    public Step Rewarded 
    => 
        new Step(nameof(Rewarded),
                 "",
                 s =>
                 {
                     
                 });
                 
    public Step Banner 
    => 
        new Step(nameof(Banner),
                 "",
                 s =>
                 {
                     
                 });
    
}
