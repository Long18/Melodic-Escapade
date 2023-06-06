using System;
using UnityEngine;

[CreateAssetMenu(fileName = "String Event Channel", menuName = "Events/String Event Channel")]
public class StringEventChannelSO : DescriptionBaseSO
{
    public event Action<string> OnEventRaised = delegate { };

#if UNITY_EDITOR
    [SerializeField] private string lastValue;
    public string LastValue => lastValue;
#endif

    public void RaiseEvent(string value)
    {
        if (OnEventRaised == null)
        {
            Debug.LogWarning($"No one is listened to {name} event channel");
            return;
        }

#if UNITY_EDITOR
        lastValue = value;
#endif

        OnEventRaised.Invoke(value);
    }
}