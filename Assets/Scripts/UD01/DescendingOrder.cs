using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    // Variables globales (no públicas para terceras personas)
    [SerializeField] private int _numberOne;
    [SerializeField] private int _numberTwo;
    [SerializeField] private int _numberThree;

    void Start()
    {
        IsDescendingOrder();
    }

    private void IsDescendingOrder()
    {
        // Estructura de control selectiva: se escoge la opción entre tres supuestos
        if (_numberOne >= _numberTwo && _numberTwo >= _numberThree) // Caso de números ordenados en decreciente
        {
            Debug.Log("Los números " + _numberOne + ", " + _numberTwo + " y " + _numberThree + " están en orden descendiente.");
        }
        else if (_numberOne == _numberTwo && _numberTwo == _numberThree) // Caso de 3 números iguales
        {
            Debug.Log("Los números " + _numberOne + ", " + _numberTwo + " y " + _numberThree + " son iguales.");
        }
        else // Caso de números NO ordenados en decreciente
        {
            Debug.Log("Los números " + _numberOne + ", " + _numberTwo + " y " + _numberThree + " no están en orden descendiente.");
        }
    }
}
