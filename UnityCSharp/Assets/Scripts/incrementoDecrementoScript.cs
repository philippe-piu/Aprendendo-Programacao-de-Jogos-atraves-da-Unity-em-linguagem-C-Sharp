using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Incremento, decremento, contador e contador de tempo*/

public class incrementoDecrementoScript : MonoBehaviour
{
    //Vari�veis 
    int numero;
    float tempo;
    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        numero++;
        Debug.Log("N�mero : " + numero);
        //Time.deltaTime � uma propriedade da da classe Time que representa o tempo em segundos no jogo
        tempo += Time.deltaTime;
        //Debug.Log("Tempo de jogo em segundos: " + tempo);
    }
}
