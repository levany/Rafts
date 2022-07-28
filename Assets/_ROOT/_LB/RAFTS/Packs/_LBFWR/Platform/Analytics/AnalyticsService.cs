using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using LB.RAFTS;
using UnityEngine;
using UnityEngine.Analytics;

namespace LB
{
    public class AnalyticsService : CriticalBehaviour
    {
        //// Lifecycle

        public override async Task OnInit(Step s)
        {
            
        }

        //// Menu Items

        public Step DoAnalyticsThing 
        => 
            new Step(nameof(DoAnalyticsThing),
                     "menu",
                     s =>
                     {
                        Unity.Services.Analytics.AnalyticsService.Instance.CustomData("MyEvent", new Dictionary<string, object>());
                     });
    }
}