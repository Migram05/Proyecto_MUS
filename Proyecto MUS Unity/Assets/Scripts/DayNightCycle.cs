using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [SerializeField]
    float rotationSpeed = 1.0f;

    [SerializeField]
    private StudioEventEmitter _emitter;
    
    private float timeSum = 0;
    public float currentTime = 0.0f;

    [SerializeField]
    private int dayHour = 10;
    [SerializeField]
    private int nightHour = 21;


    void Update()
    {
        gameObject.transform.Rotate(rotationSpeed * Time.deltaTime, 0f, 0f);
        timeSum += (rotationSpeed * Time.deltaTime);
        currentTime = ((timeSum / 360) * 24) % 24;
        _emitter.SetParameter("Day", (currentTime > dayHour && currentTime < nightHour) ? 1 : 0);
    }
}
