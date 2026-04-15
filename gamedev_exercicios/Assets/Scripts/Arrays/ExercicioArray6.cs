using UnityEngine;

public class ExercicioArray6 : MonoBehaviour
{
    [SerializeField] private int[] numeros = new int[10];
    [Header("Procurar número no Array [1-20]")]
    [SerializeField] int numeroProcurado;
    void Start()
    {
        int i = 0;
        int y = numeros.Length - 1;
        bool existe = false;

        while (i < numeros.Length) 
        {
            numeros[i] = Random.Range(1,21);
            i++;
        }

        i = 0;
        while (i < numeros.Length / 2)
        {
            if (numeros[i] == numeroProcurado)
            {
                existe = true;
                break;
            }
            if (numeros[y] == numeroProcurado)
            {
                existe = true;
                break;
            }
            y--;
            i++;
        }
        if (existe)
            print("O numero está no array");
        else
            print("O numero não está no array");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
