using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Void Action Event Channel", menuName = "Events/Void Action Event Channel")]
public class VoidActionEventChannel : DescriptionBaseSO
{
    public event Action<Action> OnEventRaised = delegate { };

    public void RaiseEvent(Action action)
    {
        if (OnEventRaised == null)
        {
            Debug.LogWarning($"No one listen to this event {name}");
            return;
        }

        OnEventRaised.Invoke(action);
    }
}