using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using LB.RAFTS;
using Unity.Services.Authentication;
using Unity.Services.Core;
using UnityEngine;

public class AuthService : CriticalBehaviour
{
    // Members
    
    public  static bool IsSignedIn = false;
    
    private static Task signinTask; 
    
    // Methods
    
    public static async Task SignIn()
    {
        if (IsSignedIn)
            return;
            
        Debug.Log("AuthService.SignIn() : " + signinTask?.Status ?? "null");
     
        await UnityServices.InitializeAsync();
        
        if (signinTask == null)
            signinTask = AuthenticationService.Instance.SignInAnonymouslyAsync();
        
        await signinTask;
        
        IsSignedIn = AuthenticationService.Instance.IsSignedIn;
    }
}
