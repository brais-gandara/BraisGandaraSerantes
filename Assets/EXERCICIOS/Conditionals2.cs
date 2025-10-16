using UnityEngine;

public class Conditionals2 : MonoBehaviour
{
    // Variables globales
    [SerializeField]
    private int _numberOne;
    [SerializeField]
    private int _numberTwo;
    [SerializeField]
    private char _letter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsPositive();
        IsAscendent();
    }

    // Update is called once per frame
    private void IsPositive()
    {
        if(_numberOne >= 0)
        {
            Debug.Log(_numberOne + " es un número positivo.");
        }
        else
        {
            Debug.Log(_numberOne + " es un número negativo.");
        }
    }
    private void IsAscendent()
    {
        if (_numberOne < _numberTwo)
        {
            Debug.Log(_numberOne + " es menor que " + _numberTwo + ".");
        }
        else if (_numberOne == _numberTwo)
        {
            Debug.Log(_numberOne + " y " + _numberTwo + " son iguales.");
        }
        else
        {
            Debug.Log(_numberOne + " es mayor que " + _numberTwo + ".");
        }
    }

    private void IsVowel()
    {
        if(_letter == 'a' || _letter == 'e')
        {
            Debug.Log(_letter + " es una vocal");
        }
    }
}
