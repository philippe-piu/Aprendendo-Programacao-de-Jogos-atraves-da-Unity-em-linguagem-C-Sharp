using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Operadores relacionais
 
 == igual
 != diferente
 > maior
 < menor
 >= maior igual
 <= menor igual 
 */


public class operadoreRelacionaisScript : MonoBehaviour
{
    //Variav�is
    int numero1 = 10;
    int numero2 = 20;
    // Start is called before the first frame update
    void Start()
    {
        //To pergunstando para a ferramenta se os numeros s�o iguais e a resposta imprime no console da Unity com um cooleando com um false ou true
        print(numero1 == numero2);

        /*Aqui fiz um condicional com if e else para exibir uma mensagem no console da Unity com dois casos se o dois n�meros s�o iguais ele imprime ul
        mensagem se n�o ele imprime outra mensagem.
          Tamb�m poderia estar usando os outros operadores relacionais neste exemplo posso ficar avontade para fazer da maneira que eu achar melhor
         */
        if (numero1 == numero2)
        {
            print("Os n�mero " + numero1 + " e o n�mero " + numero2 + " � s�o iguais");
        }
        else
        {
            print("Os n�mero " + numero1 + " e o n�mero " + numero2 + " � s�o diferentes");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
