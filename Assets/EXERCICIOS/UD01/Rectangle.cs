using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : MonoBehaviour
{
    //variables globales

    private float _height,
                  _width;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        _height = 6.1f;
        _width = 12.5f;

        GetArea();
        GetPerimeter();
        GetDiagonal();
        
    }

    // Update is called once per frame
    private void GetArea()
    {

        // variables locales (NO NECESITAN _)
        float area = 0.0f;

        // calcular área
        area = _height * _width;

        // Mostrar por consola área rectángulo

        Debug.Log("El área del rectángulo es: " + area);

        
    }
    private void GetPerimeter()
    {
        // variables locales (NO NECESITAN _)
        float perimeter = 0.0f;

        // calcular perímetro
        perimeter = 2 * (_height * _width);

        // Mostrar por consola perímetro rectángulo
        Debug.Log("El perímetro del rectángulo es: " + perimeter);

    }

    private void GetDiagonal()
    {
        // variables locales (NO NECESITAN _)
        float diagonal = 0.0f;

        // calcular perímetro
        diagonal = Mathf.Sqrt(Mathf.Pow(_width, 2) + Mathf.Pow(_height, 2));

        // Mostrar por consola diagonal rectángulo
        Debug.Log("La diagonal del rectángulo es: " + diagonal);

    }


}
