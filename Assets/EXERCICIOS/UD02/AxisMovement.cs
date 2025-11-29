using UnityEngine;

public class AxisMovement : MonoBehaviour
{
    // Variables globales
    [SerializeField] private float _speed = 0.8f; // para movemento (arr(ab)
    [SerializeField] private float _turnSpeed = 45f; // para rotación (der/esq)
    [SerializeField] private float _horizontal;
    [SerializeField] private float _vertical;
    void Update()
    {
        InputCube(); // todo input con entrada de datos chámase dende o Update
    }

    // Update is called once per frame
    private void InputCube() 
    {
        // Teclas A D | < >
        _horizontal = Input.GetAxis("Horizontal"); // será o mesmo nome que en Project Settings. Asígnase a un float
        // Teclas W A | ^ v
        _vertical = Input.GetAxis("Vertical");

        // Aplicación eixo vertical a Translate
        transform.Translate(Vector3.forward * _vertical * _speed * Time.deltaTime);
        // Aplicación eixo horizontal a Rotate
        transform.Rotate(Vector3.up * _horizontal * _turnSpeed * Time.deltaTime);
        // Pódense mapear máis letras
    }
}
