using UnityEngine;

public class exercicioArray2 : MonoBehaviour
{

    [SerializeField] private int[] vetorNumeros = new int[3];
    void Start()
    {
        int soma = 0;

        int i = 0;
        while(i < vetorNumeros.Length)
        {
            vetorNumeros[i] = Random.Range(1,11);
            i++;
        }
        i = 0;
        while (i < vetorNumeros.Length)
        {
            print("Numero aleatório " + (i + 1) + ": " + (vetorNumeros[i]));
            i++;
        }
        i = 0;
        
        while(i < vetorNumeros.Length)
        {
            soma += vetorNumeros[i];
            i++;
        }
        print("Soma: " + (soma));
    }

    
    void Update()
    {
        
    }
}
