using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TriggerEvents : MonoBehaviour
{
    public bool isOn = false;
    void Update()
    {
        if (isOn)
        {
            EventManager.instance.EventActive();
        }
    }

}
