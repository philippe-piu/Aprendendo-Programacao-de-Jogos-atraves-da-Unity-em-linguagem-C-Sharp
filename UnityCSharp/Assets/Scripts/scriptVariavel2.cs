using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Apreendendo sobre vari�veis globais e Locais
/*Vari�veis locais s� podem ser acessadas detro do m�todo de onde ela foi criada j� a globais podemos acessar de qualquer m�todo criado no seu c�digo*/
public class scriptVariavel2 : MonoBehaviour
{
    //Vari�veis Globais 
    int vidaPlayer = 10;
    int atackEnemy = 2;
    float jumpForce = 5.5f;
    bool mortePlayer = false;

    string nomePlayer = "Player Teste";
    // Start is called before the first frame update
    void Start()
    {
        //Vari�veis local
        string nomeEnemy = "Enemy Teste";
        print("Nome do inimigo �: " + nomeEnemy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
