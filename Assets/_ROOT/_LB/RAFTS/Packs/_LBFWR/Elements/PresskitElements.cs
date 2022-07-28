using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using Object = UnityEngine.Object;
using System.Threading.Tasks;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.Recorder;
#endif // UNITY_EDITOR

public class PresskitElements : MonoBehaviour
{
    #if UNITY_EDITOR
    
    [MenuItem("Rafts/Elements/Presskit/EditorScreenshot")]
     private static void TakeEditorScreenshot()
     {
         var dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Presskit/";
         Directory.CreateDirectory(dir);

         var filename = "EditorScreenshot.png";
         var path = dir + filename;         
     }
    
     [MenuItem("Rafts/Elements/Presskit/Screenshot")]
     private static void TakeScreenshot()
     {
         var dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Presskit/";
         Directory.CreateDirectory(dir);

         var filename = "Screenshot.png";
         var path = dir + filename;
         
         ScreenCapture.CaptureScreenshot(path);
         
         
         Debug.Log($"Screenshot saved: <b>{path}</b>");   
     }
     
     [MenuItem("Rafts/Elements/Presskit/Record")]
     private static async Task RecordVideo()
     {
         Debug.Log("Start");
         
         await Task.Delay(3000);
         
         Debug.Log("End");
     }

    
    #endif // UNITY_EDITOR
}
