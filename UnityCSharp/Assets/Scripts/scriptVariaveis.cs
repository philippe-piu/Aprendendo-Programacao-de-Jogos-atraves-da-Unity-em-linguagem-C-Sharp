using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Criando Variaveis e aprendendo sobre os métodos Start e Update
public class scriptVariaveis : MonoBehaviour
{
    //Tipos de Variáveis
    int vidaPlayer = 10;
    int atackEnemy = 2;
    float jumpForce = 5.5f;
    bool mortePlayer = false;
    string nomePlayer = "Player Teste";

    // Start is called before the first frame update
    void Start()
    {
        //Imprimir valor da variável no console da Unity aqui só imprime uma vez só quando inicia já que é Start
       // print("Pontos de vida do Player é: "+vidaPlayer);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Imprimir valor da variável no console da Unity aqui só imprime varias vezes frame a frame já que está na update
        print("2 Pontos de vida do Player é: " + vidaPlayer);
    }
}
