#if  UNITY_EDITOR

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RaftsSliceGenerator : MonoBehaviour
{
    public GameObject SlicePrefab;
    public GameObject PropPrefab;

    public static RaftsSliceGenerator instance;

    public RaftsSliceGenerator()
    {
        instance = this;
    }

    
    [MenuItem("Rafts/Slices/Prop")]
    public static void GenerateProp()
    {
        PrefabUtility.InstantiatePrefab(instance.PropPrefab);
    }

    [MenuItem("Rafts/Slices/Slice")]
    public static void GenerateSlice()
    {
        //// Prefab 
        
        // var slice = new GameObject("slice");
        //
        // AssetDatabase.DeleteAsset("Assets/TEMP");
        // AssetDatabase.CreateFolder("Assets", "TEMP");
        // AssetDatabase.CreateFolder("Assets/TEMP", "Prefabs");
        // PrefabUtility.SaveAsPrefabAsset(slice, "Assets/TEMP/prefabs/slice.prefab");
        //
        // DestroyImmediate(slice);
        
        PrefabUtility.InstantiatePrefab(instance.SlicePrefab);
        
        //// Scene
            // Menu
            // HUD
            // 2D
            // 3D
    
        //// Props
            
            // Code
            // Model
            // Animation
            // Audio
            // Physics
        
        //// Data
            // Objects
            // Fields
    
        //// Setup
            // (editable)
            
            
        ///////////////////////////////////////    
            
        //// Systems
            // Events
            // Cues
            // Actions
            // Items
        
        #region system 
        
        /// Events
        ///     OnInput
        ///     OnCollision
        ///     OnScore
        ///     OnStep
        ///
        /// Cues
        ///     Manual events
        ///
        /// Actions
        ///     Behaviours
        ///     Steps
        ///     Actions
        ///
        /// Items
        ///     Blackbord
        ///
        
        /// Pong example 
        ///
        /// ball system :
        ///     event - onCollideWithEdge
        ///         item - score++ 
        ///         action - reset
        
        #endregion // system
        
        ///////////////////////////////////////
        
        //// Scenario
            // Setup
            // Step
            
        //// Flow
            // Steps
            
        //// Product
            // info
            // store
            
        //////////////////////// Match
        
        //////////////////////// Line
        //////////////////////// Team
        //////////////////////// Campaign
            
    }
    
}

#endif