using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DaytimeSwitcher : MonoBehaviour
{
    public UnityEvent OnSwitchToNight, OnSwitchToDay;
    public bool isDaytime;

    KeyCode switchKey = KeyCode.Q;

    private void Update()
    {
        // Update functie wordt automatisch elke frame uitgevoerd

        // Heb ik op de 'switchKey' gedrukt? zo ja, voer dan de Switch functie uit
        if (Input.GetKeyDown(switchKey))
        {
            Switch();
        }
    }

    public void Switch()
    {
        isDaytime = !isDaytime; // Als het nu dag is, maak het nacht. Als het nu nacht is, maak het dag

        if (isDaytime) 
        { 
            // Als het nu dag is, vertel alle 'luisteraars' van deze event dat het nu dag is
            OnSwitchToDay?.Invoke();
            Debug.Log("Nu is het dag");
        }
        else 
        {
            // Als het NIET nu dag is, vertel dan de luisteraars van deze event dat het nacht is
            OnSwitchToNight?.Invoke();
            Debug.Log("Nu is het nacht");
        }
        // De 'luisteraars' kan je zetten in de inspector in unity
    }
}