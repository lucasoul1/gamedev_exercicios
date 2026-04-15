using UnityEngine;

public class ExercicioArray5 : MonoBehaviour
{
    [SerializeField] private int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    void Start()
    {
        int i = 0;
        int pares = 0;
        while (i < numeros.Length)
        {
            if (numeros[i] % 2 == 0)
            {
                pares++;
            }
            i++;
        }
        print("Quantidade de Pares: " + (pares));
    }

    
    void Update()
    {
        
    }
}
