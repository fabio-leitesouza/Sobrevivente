using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaInimigo : MonoBehaviour
{
    public GameObject Jogador;
    public float Velocidade = 5; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        float distancia = Vector3.Distance(transform.position, Jogador.transform.position);

        if(distancia > 2)
        {
            Vector3 direcao = Jogador.transform.position - transform.position;
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + direcao * Velocidade * Time.deltaTime);
        }

        
    }
}
