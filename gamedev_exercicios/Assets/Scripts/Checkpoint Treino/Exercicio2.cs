using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] nomes = new string[] {"Rafael", "Gustavo", "Ana", "Carol", "Murilo"};
        int quantidadeNomes = 5;
        for(int i = 0;  i < quantidadeNomes; i++)
        {
            nomes[i] = nomes[i].ToUpper();
        }
        foreach (string nome in nomes) 
        {
            print(nome);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
