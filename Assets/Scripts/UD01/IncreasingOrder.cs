using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    // Variables globales (no públicas para terceras personas)
    [SerializeField] private int _numberOne;
    [SerializeField] private int _numberTwo;
    [SerializeField] private int _numberThree;

    void Start()
    {
        IsIncreasingOrder();
    }

    private void IsIncreasingOrder()
    {
        // Estructura de control selectiva: se escoge la opción entre tres supuestos
        if (_numberOne <= _numberTwo && _numberTwo <= _numberThree) // Caso de números ordenados en creciente
        {
            Debug.Log("Los números " + _numberOne + ", " + _numberTwo + " y " + _numberThree + " están en orden ascendente.");
        }
        else if(_numberOne == _numberTwo && _numberTwo == _numberThree) // Caso de 3 números iguales
        {
            Debug.Log("Los números " + _numberOne + ", " + _numberTwo + " y " + _numberThree + " son iguales.");
        }
        else // Caso de números NO ordenados en creciente
        {
            Debug.Log("Los números " + _numberOne + ", " + _numberTwo + " y " + _numberThree + " no están en orden ascendente.");
        }
    }
}
