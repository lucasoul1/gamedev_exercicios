using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Exercicio5 : MonoBehaviour
{
    [SerializeField] private int teste;
    [SerializeField] private bool tentarNovamente = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && tentarNovamente) 
        {
            if (teste == 0 || teste == 1)
                print("Não Primo");
            else if (teste == 2 || teste == 3)
                print("Primo");
            else if (teste % 2 == 0 || teste % 3 == 0)
                print("Não é Primo");
            else
                print("Primo");
        }
        else if (Input.anyKeyDown)
        {
            print("FIM.");
        }
    }
}
