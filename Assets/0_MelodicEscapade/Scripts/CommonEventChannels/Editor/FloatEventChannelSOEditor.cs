using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(FloatEventChannelSO), editorForChildClasses: true)]
public class FloatEventChannelSOEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        var e = target as FloatEventChannelSO;
        if (GUILayout.Button($"Raise {e.name}"))
        {
            e.RaiseEvent(e.LastValue);
        }
    }
}