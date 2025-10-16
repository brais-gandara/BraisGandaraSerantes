using System;
using System.Drawing;
using UnityEngine;

public class Number : MonoBehaviour
{
    // Variables globales (pública porque un tercero debe poder introducir un número)
    public int UserNumber;

    void Start()
    {
        // Llamada al método
        AddToNumber(UserNumber);
    }

    public void AddToNumber(int number)
    {
        // Incremento de +1 al número deleccionado
        int result = UserNumber + 1;
        Debug.Log("La suma de 1 con el número sumado es: " + result);
    }
}
