using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "List String Event Channel", menuName = "Events/List String Event Channel")]
public class ListStringEventChannelSO : DescriptionBaseSO
{
    public event Action<List<string>> OnEventRaised = delegate { };

#if UNITY_EDITOR
    [SerializeField] private List<string> lastValue;
    public List<string> LastValue => lastValue;
#endif

    public void RaiseEvent(List<string> value)
    {
        if (OnEventRaised == null)
        {
            Debug.LogWarning($"No one listening to this event: {name}");
            return;
        }
#if UNITY_EDITOR
        lastValue = value;
#endif
        OnEventRaised.Invoke(value);
    }
}