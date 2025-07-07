using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TestEvent : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EventManager.instance.onEventActive += OnEventBecomeActive;
    }

    private void OnEventBecomeActive()
    {
        Debug.Log("Event Triggered");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
