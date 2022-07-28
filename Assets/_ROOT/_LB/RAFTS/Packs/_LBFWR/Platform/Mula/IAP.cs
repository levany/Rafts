using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using LB.RAFTS;
using UnityEngine;

public class IAP : CriticalBehaviour
{
    // Lifecycle
    
    public override async Task OnInit(Step s)
    {   
    }

    // Menu Items

    public Step InAppPurchase 
    => 
        new Step(nameof(InAppPurchase),
                 "menu",
                 s =>
                 {
                     
                 });
    
}
