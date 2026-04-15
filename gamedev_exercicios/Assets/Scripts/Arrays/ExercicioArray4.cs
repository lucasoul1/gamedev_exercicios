using UnityEngine;

public class ExercicioArray4 : MonoBehaviour
{
    [SerializeField] private int[] numeros = new int[] {1,2,3,4,5};
    void Start()
    {
        int i = 0;
        int y = numeros.Length - 1;
        int temp;
        while (i < numeros.Length / 2)
        {
            temp = numeros[i];
            numeros[i] = numeros[y];
            numeros[y] = temp;
            y--;
            i++;
        }
        i = 0;
        while (i < numeros.Length)
        {
            print(numeros[i]);
            i++;
        }
    }

    
    void Update()
    {
        
    }
}
