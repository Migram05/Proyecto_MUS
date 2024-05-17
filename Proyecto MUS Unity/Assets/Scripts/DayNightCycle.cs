using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [SerializeField]
    float rotationSpeed = 1.0f;

    private float timeSum = 0;
    public float currentTime = 0.0f;

    void Update()
    {
        gameObject.transform.Rotate(rotationSpeed * Time.deltaTime, 0f, 0f);
        timeSum += (rotationSpeed * Time.deltaTime);
        currentTime = ((timeSum / 360) * 24) % 24;
    }
}
