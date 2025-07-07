using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TestEvent : MonoBehaviour
{

    void Start()
    {
        EventManager.instance.onEventActive += OnEventBecomeActive; // subscribe to event manager event
    }

    private void OnEventBecomeActive() // to be called from another scrpt
    {
        Debug.Log("Event Triggered"); // to trigger when event is invoked
    }

}
