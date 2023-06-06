using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(BoolEventChannelSO), editorForChildClasses: true)]
public class BoolEventChannelSOEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        var e = target as BoolEventChannelSO;
        if (GUILayout.Button($"Raise {e.name}"))
        {
            e.RaiseEvent(e.LastValue);
        }
    }
}