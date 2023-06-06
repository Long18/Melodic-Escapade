using UnityEngine;

/// <summary>
/// Base on ScriptableObjects that need a public description field.
/// </summary>
public class DescriptionBaseSO : ScriptableObject
{
    [Space(10), TextArea, Tooltip("Describe the function of this SO")]
    public string Description;
}