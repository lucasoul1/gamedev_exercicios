using UnityEngine;

public class Exercicio3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Variáveis
        int[] notas = new int[10];

        for (int i = 0; i < notas.Length; i++) 
        {
            notas[i] = Random.Range(0,11);
        }
        print("Notas: ");
        foreach(int nota in notas) 
        {
            if (nota >= 6)
                print("Nota: " + (nota) + " " + "Aprovado");
            else
                print("Nota: " + (nota) + " " + "Reprovado");

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
