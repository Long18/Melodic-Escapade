﻿using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(IntEventChannelSO), editorForChildClasses: true)]
public class IntEventChannelSOEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        var e = target as IntEventChannelSO;
        if (GUILayout.Button($"Raise {e.name}"))
        {
            e.RaiseEvent(e.LastValue);
        }
    }
}