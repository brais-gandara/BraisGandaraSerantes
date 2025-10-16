using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    // Variables globales (privadas porque no requieren uso desde Inspector)
    private int _number;

    void Start()
    {
        // Llamada al método
        GetMultiplesOfThreeTwo0to100();
    }

    private void GetMultiplesOfThreeTwo0to100()
    {
        // Bucle que recoge desde el 0 a números inferiores o iguales a 100
        for (int i = 0; i <= 100; i++)
        {
            // Fórmula para múltiplos de 3 y 2
            if (i % 3 == 0)
            {
                Debug.Log("Los números múltiplos de 3 desde el 0 al 100 son: " + i);
            }
            if (i % 2 == 0)
            {
                Debug.Log("Los números múltiplos de 2 desde el 0 al 100 son: " + i);
            }

        }
    }
}
