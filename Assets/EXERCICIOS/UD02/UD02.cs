using UnityEngine;

public class UD02 : MonoBehaviour
{
    [SerializeField]
    private Color _myColor = Color.white;
    [SerializeField]
    private Vector2 _myVectorTwo = new Vector2(2.5f, 3.5f); // 2 eixos
    [SerializeField]
    private Vector3 _myVectorThree = new Vector3(2.5f, 3.5f, 6.5f); // 3 eixos
    [SerializeField]
    private Quaternion _myQuaternion = Quaternion.identity; // Cálculos complexos NASA/xogos para ROTACIÓN. W = orientación
    /* void IsAwake = nada máis se preme en Play.
       void Start = primeiro fotograma
       void FixedUpdate = para físicas
       void Update =para obxectos
       void LateUpdate
    */

    void Update()
    {
        Vector2 myOrigin = new Vector2(0.0f, 0.0f);
        Vector2 myPoint = new Vector2(4.0f, 6.0f);
        Debug.DrawLine(myOrigin, myPoint, Color.blue);
    }
}
