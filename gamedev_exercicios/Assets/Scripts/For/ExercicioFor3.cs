using UnityEngine;

public class ExercicioFor3 : MonoBehaviour
{
    [SerializeField] private string[] nome = new string[] {"Adriano", "Lucas", "Caio"};
    void Start()
    {
        int quantidadeNomes = 0;
        for (int i = 0; i < nome.Length; i++) 
        {
            if (nome[i].StartsWith("a") || nome[i].StartsWith("A")) 
            {
                print(nome[i]);
                quantidadeNomes++;
            }
        }
        print("Quantidade Nomes: " + (quantidadeNomes));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
