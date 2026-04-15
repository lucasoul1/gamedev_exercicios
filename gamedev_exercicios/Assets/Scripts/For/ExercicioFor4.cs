using UnityEngine;

public class ExercicioFor4 : MonoBehaviour
{
    [SerializeField] private string[] palavras = new string[] { "Futebol", "Basquete", "Baseball", "Volei", "PingPong" };
    void Start()
    {
        for(int i = 0; i < palavras.Length; i++)
        {
            if(i % 2 == 0)
            {
                print(palavras[i].ToUpper());
            }
            else
                print(palavras[i].ToLower());
        }
    }

    
    void Update()
    {
        
    }
}
