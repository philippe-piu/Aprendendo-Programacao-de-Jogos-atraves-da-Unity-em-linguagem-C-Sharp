using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Conhecendo e apreendendo a criar métodos com e sem retorno
public class metodosScript : MonoBehaviour
{
    int numero1, numero2, resultadoRetorno;

    // Start is called before the first frame update
    void Start()
    {
        //iniciando variavéis
        numero1 = 15;
        numero2 = 10;

        //Iniciando métodos com e sem parâmetros
        Soma();
        Multiplicacao(numero1, numero2);
        resultadoRetorno = Subtracao(numero1, numero2);
        //Imprimir no console o resultado deste método
        Debug.Log("O resultado de " + numero1+ " - " + numero2+ " = " +resultadoRetorno);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Método Soma um método sem retorno
    void Soma()
    {
        int resultado = numero1 + numero2;
        //Debug.Log imprime mensagens no console, auxiliando na verificação se os parâmetros estão sendo passados corretamente. A forma de uso é flexível e depende da sua preferência.
        Debug.Log("O resultado de " + numero1 + " + " + numero2 + " = " + resultado);
    }

    //Método Multiplicação com parâmentros e sem retorno
    void Multiplicacao(int valorA, int valorB)
    {
        int resultado = valorA * valorB;
        Debug.Log("O resultado de " + valorA + " x " + valorB + " = " + resultado);
    }

    //Método Subtração com Retorno com parâmetros
    int Subtracao(int valorA, int valorB)
    {
        int resultado = (valorA - valorB);
        return resultado;
    }
}
