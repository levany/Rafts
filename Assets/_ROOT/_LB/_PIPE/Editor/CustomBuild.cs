using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEditor.Callbacks;
using UnityEngine;

public class CustomBuild 
{
    #if UNITY_CLOUD_BUILD
    
    public static void PreExport(UnityEngine.CloudBuild.BuildManifestObject manifest)
    {
        /*
        scmCommitId	            The commit or changelist that was built.
        scmBranch	            The name of the branch that was built.
        buildNumber	            The Cloud Build “build number” corresponding to this build.
        buildStartTime	        The UTC timestamp when the build process started.
        projectId	            The Unity project identifier.
        bundleId	            The bundleIdentifier configured in Cloud Build (iOS and Android only).
        unityVersion	        The version of Unity that Cloud Build used to create the build.
        xcodeVersion	        The version of XCode used to build the Project (iOS only).
        cloudBuildTargetName	The name of the build target that was built.
        */
        
        var scmCommitId          = manifest.GetValue<string>("scmCommitId").ToString();
        var scmBranch            = manifest.GetValue<string>("scmBranch").ToString();
        var buildNumber          = manifest.GetValue<string>("buildNumber").ToString();
        var buildStartTime       = manifest.GetValue<string>("buildStartTime").ToString();
        var projectId            = manifest.GetValue<string>("projectId").ToString();
        var bundleId             = manifest.GetValue<string>("bundleId").ToString();
        var unityVersion         = manifest.GetValue<string>("unityVersion").ToString();
        var xcodeVersion         = manifest.GetValue<string>("xcodeVersion").ToString();
        var cloudBuildTargetName = manifest.GetValue<string>("cloudBuildTargetName").ToString().ToLower();
    
        // example :
        //if (cloudBuildTargetName.Contains("windows") && cloudBuildTargetName.Contains("64"))
        
        Debug.Log($"LB - PRE EXPORT");
        Debug.Log($"LB - target name : {cloudBuildTargetName}");
    }
    
    #endif
    
    public static void PostExport(string exportPath)
    {
        Debug.Log($"LB - POST EXPORT - export path : {exportPath}");
    }
}



public class MyBuildPostprocessor 
{
    [PostProcessBuild(1)]
    public static void OnPostprocessBuild(BuildTarget target, string pathToBuiltProject) 
    {
        
        Debug.Log($"LB - POST.");
        Debug.Log($"LB - POST PROCCESS BUILD (1)");
        Debug.Log($"LB - target : {target.ToString()} ");
        Debug.Log($"LB - pathToBuildProject : {pathToBuiltProject} ");
    }
}

 class MyCustomBuildProcessor : IPreprocessBuild, IPreprocessBuildWithReport
 {
      public int callbackOrder => 0;
      

      public void OnPreprocessBuild(BuildTarget target, string path) 
      {
            Debug.Log($"LB - .");
            Debug.Log($"LB - PRE PROCESS BUILD (0)");
            Debug.Log($"LB - target : {target}");
            Debug.Log($"LB - path : {path}");
      }
      
      public void OnPreprocessBuild(BuildReport report)
      {
            Debug.Log($"LB - .");
            Debug.Log($"LB - PRE PROCCESS BUILD WITH REPORT (0)");
            Debug.Log($"LB - Files (count)             : {report.files.Length}");
            Debug.Log($"LB - Steps (count)             : {report.steps.Length}");
            Debug.Log($"LB - summary.result            : {report.summary.result}");
            Debug.Log($"LB - summary.path              : {report.summary.outputPath}");
            Debug.Log($"LB - summary.GUID              : {report.summary.guid}");
            Debug.Log($"LB - packedAssets (count)      : {report.packedAssets.Length}");
            Debug.Log($"LB - strippingInfo             : {report.strippingInfo?.name}");
            Debug.Log($"LB - scenesUsingAssets (count) : {report.scenesUsingAssets?.Length}");
      }
 }

// Other events :
/*
PostProcessBuildAttribute
PostProcessSceneAttribute
RunAfterAssemblyAttribute
RunAfterClassAttribute
RunAfterPackageAttribute
RunBeforeAssemblyAttribute
RunBeforeClassAttribute
RunBeforePackageAttribute
*/