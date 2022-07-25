using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;


public class RemoteEditorWindow : EditorWindow
{
    [MenuItem("Rafts/Platform/Remote")]
    public static void ShowExample()
    {
        RemoteEditorWindow wnd = GetWindow<RemoteEditorWindow>();
        wnd.titleContent = new GUIContent("Remote");
    }

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // VisualElements objects can contain other VisualElement following a tree hierarchy.
        VisualElement label = new Label("Hello World! From C#");
        root.Add(label);
        
    }
}