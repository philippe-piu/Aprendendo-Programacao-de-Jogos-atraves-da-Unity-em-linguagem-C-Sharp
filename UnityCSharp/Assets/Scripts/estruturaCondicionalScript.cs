using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Estrutura Condicionais com e sem operadores tern�rios */
public class estruturaCondicionalScript : MonoBehaviour
{
    //Vari�veis 
    int numero = 18;
    int numero2 = 30;
    string resultado;
    // Start is called before the first frame update
    void Start()
    {
        //Uma condiciona se a pessoa for tiver 18 anos ou mais ela pode jogar se n�o ela n�o pode
        if (numero >= 18)
        {
            print("Pessoa do Teste tem mais de " + numero + " ent�o ela pode jogar este jogo.");
        }
        else
        {
            print("Pessoa do Teste � menor de idade tem  " + numero + " ent�o ela n�o pode jogar este jogo.");
        }

        //Condicionais com Operadores Tern�rios
        //condi��o ? valor a ser atribuido caso verdadeiro : caso seja falso
        resultado = numero > numero2 ? "Sim" : "N�o";
        Debug.Log(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
