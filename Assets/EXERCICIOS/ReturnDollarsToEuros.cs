using UnityEngine;

public class ReturnDollarsToEuros : MonoBehaviour
{
    // variables globales
    private float _euro;
    public float Dollar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _euro = 0.90f;
        Debug.Log(GetDollarToEuro()); // no se pone 'conversion' porque es local y no global
    }

    // Update is called once per frame
    private float GetDollarToEuro()
    {
        // variables locales
        float conversion = 0.0f;

        // Calcular conversión dólares/euros
        conversion = Dollar * _euro;

        // Devolver valor tipo 'float'
        return conversion;
    }
}
