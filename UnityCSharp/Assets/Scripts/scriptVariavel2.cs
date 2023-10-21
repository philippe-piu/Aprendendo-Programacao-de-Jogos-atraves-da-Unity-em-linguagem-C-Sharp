using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Apreendendo sobre variáveis globais e Locais
/*Variáveis locais só podem ser acessadas detro do método de onde ela foi criada já a globais podemos acessar de qualquer método criado no seu código*/
public class scriptVariavel2 : MonoBehaviour
{
    //Variáveis Globais 
    int vidaPlayer = 10;
    int atackEnemy = 2;
    float jumpForce = 5.5f;
    bool mortePlayer = false;

    string nomePlayer = "Player Teste";
    // Start is called before the first frame update
    void Start()
    {
        //Variáveis local
        string nomeEnemy = "Enemy Teste";
        print("Nome do inimigo é: " + nomeEnemy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
