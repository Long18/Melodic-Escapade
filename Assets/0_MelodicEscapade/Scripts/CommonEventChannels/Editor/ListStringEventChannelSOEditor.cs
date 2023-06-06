using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ListStringEventChannelSO), editorForChildClasses: true)]
public class ListStringEventChannelSOEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        var e = target as ListStringEventChannelSO;
        if (GUILayout.Button($"Raise {e.name}"))
        {
            e.RaiseEvent(e.LastValue);
        }
    }
}