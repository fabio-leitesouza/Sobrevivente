using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaFaca : MonoBehaviour
{
    public GameObject Faca;
    public GameObject CaboFaca;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
             Instantiate(Faca, CaboFaca.transform.position, CaboFaca.transform.rotation);
        }       
    }
}
