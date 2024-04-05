using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faca : MonoBehaviour
{
    public float Velocidade = 20;

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.forward * Velocidade);
    }
}
