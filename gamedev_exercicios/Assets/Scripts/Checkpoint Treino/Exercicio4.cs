using UnityEngine;

public class Exercicio4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int contador = 1;
        int multiplos = 0;
        while (contador <= 20)
        {
            print(contador);
            if (contador % 3 == 0)
            {
                multiplos++;
            }
            contador++;
        }
        print("Quantidade Multiplos: " + multiplos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
