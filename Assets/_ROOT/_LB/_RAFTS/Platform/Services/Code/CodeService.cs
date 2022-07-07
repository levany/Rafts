using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Services.Authentication;
using Unity.Services.CloudCode;
using Unity.Services.Core;
using UnityEngine;

public class CodeService : MonoBehaviour
{
    //// Lifecycle methods

    public async void Start()
    {
        await UnityServices.InitializeAsync();
        await AuthService.SignIn();
        await DoThings();
    }

    // Methods
    
    public async Task DoThings()
    {
        await Task.Delay(1000);
        
        Debug.Log("CodeService.DoThings()");
    
        var response = await CloudCodeService.Instance.CallEndpointAsync<CloudCodeResponse>("HelloWorld", default);
        Debug.Log(response.message);
    }

    //// Types

    private class CloudCodeResponse
    {
        public string message;
    }
    
    //// Cloud Code
    
    /// ////////////////////////////////////////////
    /// The HelloWorld Script in the cloud :
    ///
    ///
    /// module.exports = async ({ params, logger }) => 
    /// {
    ///   const message = `Hello from the cloud!`
    ///
    ///   logger.debug(message);
    ///   
    ///   return {
    ///     message: message
    ///   };
    /// }; 
    ///
    /// ////////////////////////////////////////////
    
}