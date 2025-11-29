using UnityEngine;

public class Rectangle2 : MonoBehaviour
{
    // variables globales

    private float _height,
                  _width;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _height = 4;
        _width = 4;

        GetArea();


    }

    // Update is called once per frame
    private void GetArea()
    {
        float area = 0.0f;
        area = _height * _width;
        Debug.Log("El área del rectángulo es: " + area);
    }
}
