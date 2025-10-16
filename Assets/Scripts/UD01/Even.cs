using UnityEngine;

public class Even : MonoBehaviour
{

    // Variables globales (privadas porque no requieren uso desde Inspector)
    private int _number;

    void Start()
    {
        // Llamada al método
        GetEvens0to100();
    }

    private void GetEvens0to100()
    {
        // Bucle que comienza desde 0 hasta un número menor o igual a 100
        for (int i = 0; i <= 100; i++)
        {
            // Fórmula para llamar a la consola a los números pares
            if (i % 2 == 0)
            {
                Debug.Log("Los números pares del 0 al 100 son: " + i);
            }

        }
    }
}
