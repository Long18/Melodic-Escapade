using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(StringEventChannelSO), editorForChildClasses: true)]
public class StringEventChannelSOEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        var e = target as StringEventChannelSO;
        if (GUILayout.Button($"Raise {e.name}"))
        {
            e.RaiseEvent(e.LastValue);
        }
    }
}