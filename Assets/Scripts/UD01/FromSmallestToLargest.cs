using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{
    // Variables globales (Serializadas para usarlas desde Inspector)
    [SerializeField]
    private int _numberOne;
    [SerializeField]
    private int _numberTwo;
    [SerializeField]
    private int _numberThree;

    void Start()
    {
        // Llamada al método
        GetSmallestToLargest();
    }
    private void GetSmallestToLargest() // Si más de un número es igual, se contabilizan ambos usando el =
    {
        if(_numberOne <= _numberTwo &&  _numberOne <= _numberThree) // CASO 1: N1 es el más pequeño (orden 123 || 132)
            if (_numberTwo <= _numberThree)
            {
                Debug.Log("El orden de los números de menor a mayor es " + _numberOne + ", " + _numberTwo + ", " + _numberThree);
            }
            else
            {
                Debug.Log("El orden de los números de menor a mayor es " + _numberOne + ", " + _numberThree + ", " + _numberTwo);
            }

        else if(_numberTwo <= _numberOne && _numberTwo <= _numberThree) // CASO 2: N2 es el más pequeño (orden 213 || 231)
            if (_numberOne <= _numberThree)
            {
                Debug.Log("El orden de los números de menor a mayor es " + _numberTwo + ", " + _numberOne + ", " + _numberThree);
            }
            else
            {
                Debug.Log("El orden de los números de menor a mayor es " + _numberTwo + ", " + _numberThree + ", " + _numberOne);
            }

        else if(_numberThree <= _numberOne && _numberThree <= _numberTwo) // CASO 3: N3 es el más pequeño (orden 312 || 321)
            if (_numberOne <= _numberTwo)
            {
                Debug.Log("El orden de los números de menor a mayor es " + _numberThree + ", " + _numberOne + ", " + _numberTwo);
            }
            else
            {
                Debug.Log("El orden de los números de menor a mayor es " + _numberThree + ", " + _numberTwo + ", " + _numberOne);
            }
    }
}
