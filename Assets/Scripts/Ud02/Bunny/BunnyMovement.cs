using UnityEngine;

public class BunnyMovement : MonoBehaviour
{

    // Variables globales, en Serializado para editar la velocidad/rotación
    [Header("Translaion and rotation speed")]
    // Variable de movimiento (^v)
    [SerializeField] private float _speed;
    // Variable de rotación (<>)
    [SerializeField] private float _turnSpeed;
    private float _horizontal;
    private float _vertical;

    void Update()
    {
        // Llamada a los métodos al iniciar
        InputBunny();
        Move();
        Turn();


    }

    private void InputBunny()
    {
    // Uso de teclas A D | < > para movimiento
    _horizontal = Input.GetAxis("Horizontal"); // Nombre igual a Project Settings
    _vertical = Input.GetAxis("Vertical"); // Nombre igual a Project Settings
    }

    private void Move()
    {
        // Aplicación de eje vertical a Translate
        transform.Translate(Vector3.forward * _vertical * _speed * Time.deltaTime);
    }

    private void Turn()
    {
        // Aplicación eje horizontal a Rotate
        transform.Rotate(Vector3.up * _horizontal * _turnSpeed * Time.deltaTime);
    }
}


