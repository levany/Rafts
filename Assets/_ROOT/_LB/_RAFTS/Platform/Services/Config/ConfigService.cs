using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.RemoteConfig;
using UnityEngine;

public class ConfigService : MonoBehaviour
{
    public async Task Start()
    {
        // Debug.Log("ConfigService.Start");
        // await InitializeRemoteConfigAsync();
        // await DoThings();
    }
    
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
        if (!AuthenticationService.Instance.IsSignedIn)
        {
            await AuthenticationService.Instance.SignInAnonymouslyAsync();
        }
        
        Debug.Log("ConfigService.InitializeRemoteConfigAsync done");
    }

    public async Task DoThings()
    {
        // RemoteConfigService.Instance.appConfig....
        
        // RemoteConfigWebApiClient
    }

}
