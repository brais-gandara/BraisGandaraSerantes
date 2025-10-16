using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    /* EX 2. VARIABLES vs asignaciones correctas
     a y b = enteros;    c y d = reales;    e y f = carácter;    g = lógico
     a = 20 (V, entero);   b = 5500 (X, largo);   a = 12.56 (X, decimal);  b = 12 (V, entero);
     f = 0 (X, número);    f = g (V, letra);      g = 'falso' (X, comas);  g = verdadero (V) 
    */

    void Start()
    {

        //VARIABLE LOCAL, solo para método concreto.
        /*float x,
              y,
              z = 3.0f;
        x = 2.0f;
        x = Mathf.Pow((x + x), 2);
        x = Mathf.Sqrt(x + Mathf.Sqrt(x) + 5);
        Debug.Log(x);*/
        int a,
            b,
            c;
        a = 3;
        b = 4;
        c = a + (2 * b);
        c = c + b;
        b = c - a;
        a = b * c;
        Debug.Log(a + b + c);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
