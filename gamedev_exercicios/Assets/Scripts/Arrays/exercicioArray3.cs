using UnityEngine;

public class exercicioArray3 : MonoBehaviour
{
    [SerializeField] private int[] numeros = new int[10];
    void Start()
    {
        int maior = 0;
        int i = 0;
        while (i < numeros.Length)
        {
            numeros[i] = Random.Range(1, 101);
            i++;
        }
        i = 0;
        while (i < numeros.Length)
        {
            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }
            i++;
        }
        print("Maior: " + (maior));
    }

    
    void Update()
    {
        
    }
}
