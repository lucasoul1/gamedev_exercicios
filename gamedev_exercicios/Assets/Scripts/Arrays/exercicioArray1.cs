using UnityEngine;

public class exercicioArray1 : MonoBehaviour
{

    [SerializeField] private int[] numeros = new int[]{1,2,3,4,5};
    void Start()
    {
        int i = 0;
        while(i < numeros.Length)
        {
            print(numeros[i]);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
