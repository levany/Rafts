using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

namespace LB
{
    public class AnalyticsService : MonoBehaviour
    {
        public void Start()
        {
            Debug.Log("AnalyticsService.Start()");
            Unity.Services.Analytics.AnalyticsService.Instance.CustomData("MyEvent", new Dictionary<string, object>());
        }
    }
}