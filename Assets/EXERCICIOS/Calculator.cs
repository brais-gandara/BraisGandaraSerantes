using System.Buffers;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    //Variables globales
    [SerializeField] private float _numberOne;
    [SerializeField] private float _numberTwo;
    [SerializeField] private bool _isAddition;
    [SerializeField] private bool _isSubtraction;
    [SerializeField] private bool _isMultiplication;
    [SerializeField] private bool _isDivision;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Operations(); 
    }

    private void Operations()
    {
        if (_isAddition == true)
        {
            GetAddition(_numberOne, _numberTwo); // se llaman a los dos números de arriba desde abajo
        }
    }

    private void GetAddition(float numberOne, float numberTwo) // sabe que necesita recoger 2 floats
    {
        float result = numberOne + numberTwo;
        Debug.Log("La suma de estos dos números es: " + result);
    }
}
