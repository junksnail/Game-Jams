using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public static EventManager instance;

    private void Awake()
    {
        instance = this;
    }

    public event Action onEventActive;
    public void EventActive()
    {
        if (onEventActive != null)
        {
            onEventActive();
        }
    }
    
}