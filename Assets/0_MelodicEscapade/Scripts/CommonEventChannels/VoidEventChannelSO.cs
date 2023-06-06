using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Void Event Channel", menuName = "Events/Void Event Channel")]
public class VoidEventChannelSO : DescriptionBaseSO
{
    public event Action OnEventRaised = delegate { };

    public void RaiseEvent()
    {
        if (OnEventRaised == null)
        {
            Debug.LogWarning($"No one is listened to {name} event channel");
            return;
        }

        OnEventRaised.Invoke();
    }
}