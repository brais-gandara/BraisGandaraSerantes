using UnityEngine;

public class Score : MonoBehaviour
{
    // Variables globales
    // Número de puntos (públicas en vez de Serializadas porque debe poder verlos)
    public int UserScore;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Operations(UserScore);
    }

    private void Operations(int userScore)
    {
        if (UserScore == 45)
        {
            Debug.Log("El usuario ha alcanzado los 45 puntos.");
        }
        else if (UserScore > 45)
        {
            Debug.Log("El usuario ha superado los 45 puntos.");
        }
        else
        {
            Debug.Log("El usuario todavía no ha alcanzado los 45 puntos.");
        }
    }
}