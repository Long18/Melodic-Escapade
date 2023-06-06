using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Int Event Channel",menuName = "Events/Int Event Channel")]
public class IntEventChannelSO : DescriptionBaseSO
{
    public event Action<int> OnEventRaised = delegate { };

#if UNITY_EDITOR
    [SerializeField] private int lastValue;
    public int LastValue => lastValue;
#endif

    public void RaiseEvent(int value)
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