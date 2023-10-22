using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Conhecendo e apreendendo a criar m�todos com e sem retorno
public class metodosScript : MonoBehaviour
{
    int numero1, numero2, resultadoRetorno;

    // Start is called before the first frame update
    void Start()
    {
        //iniciando variav�is
        numero1 = 15;
        numero2 = 10;

        //Iniciando m�todos com e sem par�metros
        Soma();
        Multiplicacao(numero1, numero2);
        resultadoRetorno = Subtracao(numero1, numero2);
        //Imprimir no console o resultado deste m�todo
        Debug.Log("O resultado de " + numero1+ " - " + numero2+ " = " +resultadoRetorno);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //M�todo Soma um m�todo sem retorno
    void Soma()
    {
        int resultado = numero1 + numero2;
        //Debug.Log imprime mensagens no console, auxiliando na verifica��o se os par�metros est�o sendo passados corretamente. A forma de uso � flex�vel e depende da sua prefer�ncia.
        Debug.Log("O resultado de " + numero1 + " + " + numero2 + " = " + resultado);
    }

    //M�todo Multiplica��o com par�mentros e sem retorno
    void Multiplicacao(int valorA, int valorB)
    {
        int resultado = valorA * valorB;
        Debug.Log("O resultado de " + valorA + " x " + valorB + " = " + resultado);
    }

    //M�todo Subtra��o com Retorno com par�metros
    int Subtracao(int valorA, int valorB)
    {
        int resultado = (valorA - valorB);
        return resultado;
    }
}
