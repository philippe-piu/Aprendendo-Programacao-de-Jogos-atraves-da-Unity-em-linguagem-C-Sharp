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
    //Variavéis
    int numero1 = 10;
    int numero2 = 20;
    // Start is called before the first frame update
    void Start()
    {
        //To pergunstando para a ferramenta se os numeros são iguais e a resposta imprime no console da Unity com um cooleando com um false ou true
        print(numero1 == numero2);

        /*Aqui fiz um condicional com if e else para exibir uma mensagem no console da Unity com dois casos se o dois números são iguais ele imprime ul
        mensagem se não ele imprime outra mensagem.
          Também poderia estar usando os outros operadores relacionais neste exemplo posso ficar avontade para fazer da maneira que eu achar melhor
         */
        if (numero1 == numero2)
        {
            print("Os número " + numero1 + " e o número " + numero2 + " é são iguais");
        }
        else
        {
            print("Os número " + numero1 + " e o número " + numero2 + " é são diferentes");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
