using System.Timers;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    // Variables Globales
    [SerializeField]
    private int _numberOne; // INTRODUCE 1 NUM. PAR/IMPAR, POS/NEG (_numberone >=0 // numberone % 2 == 0)
    [SerializeField]
    private int _numberTwo; // INTRODUCE 2 NUM. MUESTRA DE FORMA ASCENDENTE
    [SerializeField]
    private char _letter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsPositive();
        IsOdd();
        IsAscendingNumber();
        IsVowel();
    }

    // Update is called once per frame
    private void IsPositive()
    {
        if (_numberOne >= 0)
        {
            Debug.Log(_numberOne + " es positivo.");
        }
        else
        {
            Debug.Log(_numberOne + " es negativo.");
        }
    }
    private void IsOdd()
    {
        if (_numberOne % 2 == 0)
        {
            Debug.Log(_numberOne + " es par.");
        }
        else
        {
            Debug.Log(_numberOne + " es impar.");
        }
    }

    private void IsAscendingNumber()
    {
        if (_numberOne < _numberTwo)
        {
            Debug.Log("El orden ascendente de los números es: " + _numberOne + "\t" + _numberTwo);
        }
        else if (_numberOne == _numberTwo)
        {
            Debug.Log("Los dos números son iguales");
        }
        else
        {
            Debug.Log("El orden ascendente de los números es: " + _numberOne + "\t" + _numberTwo);
        }
    }

    private void IsVowel()
    {
        if (_letter == 'a' || _letter == 'A' || _letter == 'e' || _letter == 'E' || _letter == 'a' || _letter == 'i' || _letter == 'I' || _letter == 'o' || _letter == 'O' || _letter == 'u' || _letter == 'U')
        {
            Debug.Log(_letter + " es una vocal.");
        }

        else
        {
            Debug.Log(_letter + " es una consonante.");
        }
    }
}
