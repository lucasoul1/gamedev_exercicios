using UnityEngine;

public class ExercicioFor2 : MonoBehaviour
{
    [SerializeField] private string[] palavra = new string[] {"Banana", "ABACAXI", "MeLaO" };
    void Start()
    {
        for (int i = 0; i < palavra.Length; i++) 
        {
            print(palavra[i].ToLower());   
        }   
    }

    
    void Update()
    {
        
    }
}
