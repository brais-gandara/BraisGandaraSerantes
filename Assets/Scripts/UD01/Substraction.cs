using UnityEngine;

public class Substraction : MonoBehaviour
{
    // Variables globales (Serializadas para que sean solo visibles por admin)
    [SerializeField]
    private int _number;

    void Start()
    {
        GetSubstraction1ToNumber();
    }

    private void GetSubstraction1ToNumber()
    {
        // Bucle que recoge desde el 1 hasta x número escogido (tipo, inicio, final, señal de bucle)
        for (int i = 1 ; i <= _number ; i++)
        {
            int result = i - 1;
            Debug.Log("La resta de los números del " + _number + " al 1 es: " + result);
        }
    }
}
