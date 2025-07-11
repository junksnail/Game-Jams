using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public static EventManager instance; // creates a singleton so the event manager is available from any script

    private void Awake() //on awake
    {
        if (instance == null) // checks to see if EventManager instance is already taken
        {
            instance = this; // if not taken, sets this as EM instance
        }
    }

    public event Action onEventActive; // creates an Event

    public void EventActive() //function to be called from another script
    {
        if (onEventActive != null) // ensures something is subscribed to this event before activating it
        {
            onEventActive(); // calls the event
        }
    }
    
}