using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Criando Variaveis e aprendendo sobre os m�todos Start e Update
public class scriptVariaveis : MonoBehaviour
{
    //Tipos de Vari�veis
    int vidaPlayer = 10;
    int atackEnemy = 2;
    float jumpForce = 5.5f;
    bool mortePlayer = false;
    string nomePlayer = "Player Teste";

    // Start is called before the first frame update
    void Start()
    {
        //Imprimir valor da vari�vel no console da Unity aqui s� imprime uma vez s� quando inicia j� que � Start
       // print("Pontos de vida do Player �: "+vidaPlayer);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Imprimir valor da vari�vel no console da Unity aqui s� imprime varias vezes frame a frame j� que est� na update
        print("2 Pontos de vida do Player �: " + vidaPlayer);
    }
}
