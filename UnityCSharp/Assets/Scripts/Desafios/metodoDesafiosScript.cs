using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Desafio: crie um m�todo com retorno e par�metros. Voc� deve criar duas vari�veis inteiras com os nomes "vidaPlayer" recebendo 100 e "ataqueInimigo" 
recebendo 10, al�m de uma vari�vel "vidaPlayerAtual" recebendo 40. O m�todo deve cacular quantos golpes voc� precisou receber do inimigo para que sua vida chegasse a 40.
*/
public class metodoDesafiosScript : MonoBehaviour
{
    //Vari�veis
    int vidaPlayer = 100;
    int atackEnemy = 10;
    int vidaPlayerAtual = 40;
    int resultadoRetorno;
    // Start is called before the first frame update
    void Start()
    {
       resultadoRetorno = QuantidadeDeGolpes(vidaPlayer, vidaPlayerAtual, atackEnemy);
       Debug.Log("Quantidade de golpes levados para vida do Player ter caido de "+vidaPlayer+ "  para "+vidaPlayerAtual+" � de " +resultadoRetorno+" golpes.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int QuantidadeDeGolpes(int valorA, int valorB, int valorC)
    {
        //pego o 100 diminuo pelo valor da vida atual e divido pelo ataque do inimigo assim retorno a quantidade de golpes levados para ver quantidade de ataques do inimigo.
        int golpesEnemy = (valorA - valorB) / valorC;

        return golpesEnemy;
    }
}
