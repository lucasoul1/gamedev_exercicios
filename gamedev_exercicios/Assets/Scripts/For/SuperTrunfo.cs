using UnityEngine;
using UnityEngine.Rendering;

public class SuperTrunfo : MonoBehaviour
{
    // Variáveis Cartas
    [SerializeField] private int[,] cartas = new int[5, 3];
    string[] atributos = new string[]{"Força", "Velocidade", "Inteligência"};
    
    // Variáveis de Controle
    int atributoSorteado;

    // Variáveis Jogadores
    int jogador1Carta, jogador2Carta;
    int jogador1Pontos, jogador2Pontos;


    void Start()
    {
        // Looping Rodadas
        for (int i = 0; i < 5; i++) 
        {
            print("Rodada " + (i + 1));

            // Gera as cartas sorteadas
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    cartas[a, b] = Random.Range(1, 10);
                }
            }

            // Carta Sorteada
            jogador1Carta = Random.Range(0, 5);
            jogador2Carta = Random.Range(0, 5);

            // Atributo Sorteado
            atributoSorteado = Random.Range(0, 3);

            // Cartas Saída
            print("Atributo: " + (atributos[atributoSorteado]));
            print("J1: " + "[" + (cartas[jogador1Carta, 0]) + "," + (cartas[jogador1Carta, 1]) + "," + (cartas[jogador1Carta,2]) + "]");
            print("J2: " + "[" + (cartas[jogador2Carta, 0]) + "," + (cartas[jogador2Carta, 1]) + "," + (cartas[jogador2Carta, 2]) + "]");

            // Rodadas Saída + Lógica
            if (cartas[jogador1Carta, atributoSorteado] == cartas[jogador2Carta, atributoSorteado])
            {
                print("Empate");
            }
            else if (cartas[jogador1Carta, atributoSorteado] > cartas[jogador2Carta, atributoSorteado])
            {
                print("Jogador 1 Venceu");
                jogador1Pontos++;
            }
            else
            {
                print("Jogador 2 Venceu");
                jogador2Pontos++;
            }
            print("");
        }

        // Saída Final
        print("Resultado Final: ");
        print("J1: " + (jogador1Pontos) + " pontos");
        print("J2: " + (jogador2Pontos) + " pontos");
        if (jogador1Pontos == jogador2Pontos)
            print("Empate entre os Jogadores");
        else if (jogador1Pontos > jogador2Pontos)
            print("Jogador 1 venceu!");
        else
            print("Jogador 2 venceu!");
    }
}
