using System.Runtime.CompilerServices;
using UnityEngine;

public class Change : MonoBehaviour
{
    // Variables globales (privadas porque no requieren uso desde Inspector)
    private int[] _fullArray = { 1, 1, 1, 1, 1};
    private int _fullArrayResult;

    void Start()
    {

        // Fórmula para señalar el número de elementos del Array
        _fullArrayResult = _fullArray[0] + _fullArray[1] + _fullArray[2] + _fullArray[3] + _fullArray[4];

        Debug.Log("El número de elementos del array es: " + _fullArrayResult);
        ChangeNumbers();

    }

    private void ChangeNumbers()
    {
        // Fórmula para cambiar en local el valor del primer y último array
        _fullArray[0] = 42;
        _fullArray[4] = 42;

        Debug.Log("Los números del array son: " + _fullArray[0] + ", " + _fullArray[1] + ", " + _fullArray[2] + ", " + _fullArray[3] + ", " + _fullArray[4]);
    }
}
