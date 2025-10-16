using UnityEngine;

public class Temperature2 : MonoBehaviour
{
    // variables globales
    [SerializeField]
    private float _celsius;
    [SerializeField]
    private float _fahrenheit;
    private float _scaleFactor;
    private float _gap;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _celsius = 0.0f;
        _fahrenheit = 0.0f;
        _scaleFactor = 1.8f;
        _gap = 32.0f;

        GetFahrenheitToCelsius();
        GetCelsiustoFahrenheit();
    }

    // Update is called once per frame
    private void GetFahrenheitToCelsius()
    {
        _celsius = _fahrenheit - _gap / _scaleFactor;
        Debug.Log(_fahrenheit + " ºF equivale a " + _celsius + " ºC.");
    }
    private void GetCelsiustoFahrenheit()
    {
        _fahrenheit = _scaleFactor * _celsius + _gap;
        Debug.Log(_celsius + " ºC equivale a " + _fahrenheit + " ºF.");
    }
}
