using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Float Event Channel", menuName = "Events/Float Event Channel")]
public class FloatEventChannelSO : DescriptionBaseSO
{
    public event Action<float> OnEventRaised = delegate { };

#if UNITY_EDITOR
    [SerializeField] private float lastValue;
    public float LastValue => lastValue;
#endif

    public void RaiseEvent(float value)
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