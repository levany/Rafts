using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DefaultPanelSettings : ScriptableObject
{
    static PanelSettings settings;
    public static PanelSettings GetDefaultPanelSettings()
    {
        if (settings == null)
        {
            settings = Resources.Load<PanelSettings>("DefaultPanelSettings");
        }
        
        return settings;
    }
}
