using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    // Variables globales (privadas porque no requieren uso desde Inspector)
    private int _number;

    void Start()
    {
        GetMultiplesOfThree0to100();
    }

    private void GetMultiplesOfThree0to100()
    {
        // Bucle que recoge desde el 0 a números inferiores o iguales a 100
        for (int i = 0; i <= 100; i++)
        {
            // Fórmula para múltiplos de 3
            if (i % 3 == 0)
            {
                Debug.Log("Los números múltiplos de 3 desde el 0 al 100 son: " + i);
            }

        }
    }
}
