using UnityEngine;

public class ExercicioFor1 : MonoBehaviour
{
    [SerializeField] private string[] nomes = new string[] { "Lucas", "Caio", "Adriano" };
    void Start()
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            print(nomes[i].ToUpper());
        }
    }

    
    void Update()
    {
        
    }
}
