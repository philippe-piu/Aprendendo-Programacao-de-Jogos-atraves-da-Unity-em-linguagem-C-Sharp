using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Estrutura Condicionais com e sem operadores ternários */
public class estruturaCondicionalScript : MonoBehaviour
{
    //Variáveis 
    int numero = 18;
    int numero2 = 30;
    string resultado;
    // Start is called before the first frame update
    void Start()
    {
        //Uma condiciona se a pessoa for tiver 18 anos ou mais ela pode jogar se não ela não pode
        if (numero >= 18)
        {
            print("Pessoa do Teste tem mais de " + numero + " então ela pode jogar este jogo.");
        }
        else
        {
            print("Pessoa do Teste é menor de idade tem  " + numero + " então ela não pode jogar este jogo.");
        }

        //Condicionais com Operadores Ternários
        //condição ? valor a ser atribuido caso verdadeiro : caso seja falso
        resultado = numero > numero2 ? "Sim" : "Não";
        Debug.Log(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
