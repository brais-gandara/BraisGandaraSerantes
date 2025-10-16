using System.Runtime.CompilerServices;
using UnityEngine;

public class Logic : MonoBehaviour
{
    // Variables globales (privadas porque no requieren uso desde Inspector)
    private bool[] _falseArray = { false, false, false };

    void Start()
    {
        // cambio del primer array a 'true'
        _falseArray[0] = true;

        Debug.Log("Los valores de los tres booleanos son: " + _falseArray[0] + ", " + _falseArray[1] + ", " + _falseArray[2]);
    }
}
