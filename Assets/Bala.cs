using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [Range(0.1f, 1000f)]
    public float velocidad=1f;

    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * velocidad;
    }
}
