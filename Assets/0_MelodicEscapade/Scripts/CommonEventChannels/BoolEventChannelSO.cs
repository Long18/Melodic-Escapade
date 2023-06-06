using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Bool Event Channel", menuName = "Events/Bool Event Channel")]
public class BoolEventChannelSO : DescriptionBaseSO
{
    public event Action<bool> OnEventRaised = delegate { };

#if UNITY_EDITOR
    [SerializeField] private bool lastValue;
    public bool LastValue => lastValue;
#endif

    public void RaiseEvent(bool value)
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