using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class HeightController : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame

    [SerializeField]
    private StudioEventEmitter _emitter;
    void Update()
    {
        _emitter.SetParameter("Altura", transform.position.y);
    }
}
