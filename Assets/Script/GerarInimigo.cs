using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarInimigo : MonoBehaviour
{
    public GameObject Inimigo;
    private float contadorTempo = 0;
    public float TempoGerarInimigo = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contadorTempo += Time.deltaTime; 

        if(contadorTempo >= TempoGerarInimigo)
        {
            Instantiate(Inimigo, transform.position, transform.rotation);
            contadorTempo = 0;
        }
        
    }
}
