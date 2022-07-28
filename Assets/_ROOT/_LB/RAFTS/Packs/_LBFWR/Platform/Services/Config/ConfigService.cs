using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using LB.RAFTS;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.RemoteConfig;
using UnityEngine;

public class ConfigService : CriticalBehaviour
{
    //// Lifecycle

    public override async Task OnInit(Step s)
    {
        await InitializeRemoteConfigAsync();
    }

    //// Menu Items

    public Step DoConfigThing 
    => 
        new Step(nameof(DoConfigThing),
                 "menu",
                 s =>
                 {
                    // RemoteConfigService.Instance.appConfig....
        
                    // RemoteConfigWebApiClient
                 });
    

    //// Methods
    
    async Task InitializeRemoteConfigAsync()
    {
        Debug.Log("ConfigService.InitializeRemoteConfigAsync started");
        
        // initialize handlers for unity game services
        await UnityServices.InitializeAsync();

        // options can be passed in the initializer, e.g if you want to set analytics-user-id or an environment-name use the lines from below:
        // var options = new InitializationOptions()
        //   .SetOption("com.unity.services.core.analytics-user-id", "my-user-id-1234")
        //   .SetOption("com.unity.services.core.environment-name", "production");
        // await UnityServices.InitializeAsync(options);

        // remote config requires authentication for managing environment information
        await AuthService.SignIn();
        
        Debug.Log("ConfigService.InitializeRemoteConfigAsync done");
    }
}
