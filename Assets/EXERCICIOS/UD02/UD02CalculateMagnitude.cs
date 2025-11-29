using UnityEngine;

public class UD02CalculateMagnitude : MonoBehaviour
{
    void Update()
    {
        Vector2 pepaBueno = new Vector2(0.0f, 0.0f);
        Vector2 clotildeMartinez = new Vector2(3.0f, 6.0f);

        float lenght = clotildeMartinez.magnitude;

        Debug.Log("La distancia entre Pepa y Clotilde es: " +  lenght);
        Debug.DrawLine(pepaBueno, clotildeMartinez, Color.yellow);
        
    }
}
