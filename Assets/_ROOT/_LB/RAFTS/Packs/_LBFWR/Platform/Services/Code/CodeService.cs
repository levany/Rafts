using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using LB.RAFTS;
using Unity.Services.Authentication;
using Unity.Services.CloudCode;
using Unity.Services.Core;
using UnityEngine;

public class CodeService : CriticalBehaviour
{
    //// Lifecycle
    
    public override async Task OnInit(Step s)
    {   
        await UnityServices.InitializeAsync();
        await AuthService.SignIn();
    }

    //// Menu Items

    public Step DoCodeThing 
    => 
        new Step(nameof(DoCodeThing),
                 "menu",
                 async s =>
                 {
                     var response = await CloudCodeService.Instance.CallEndpointAsync<CloudCodeResponse>("HelloWorld", default);
                     s.Log(response.message);
                 });
    
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