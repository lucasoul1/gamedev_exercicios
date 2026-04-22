using UnityEngine;

public class Exercicio1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] numeros = new int[10];
        const int quantidadeNumeros = 10;
        int temp;
        for(int i = 0; i < quantidadeNumeros; i++)
        {
            temp = Random.Range(2,1001);
            if (temp % 2 == 0)
            {
                numeros[i] = temp;
            }
            else
            {
                i--;
            }
        }
        foreach(int numero in numeros)
        {
            print(numero);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
