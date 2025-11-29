using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class MovementPlayer : MonoBehaviour
{
    // Zona de variables globales
    [Header("Translation and rotation speed")]
    [SerializeField] private float _speed;     // Variable de movimiento (^v)
    [SerializeField] private float _turnSpeed; // Variable de rotación (<>)
    private float _vertical;
    private float _horizontal;

    private Animator _animation;

    private Ray _ray;
    private RaycastHit _hit;
    [SerializeField] private float _rayLenght; // Marca la distancia del Raycast
    [SerializeField] private LayerMask _rayMask; // Marca a qué capa afecta el Raycast

    private Rigidbody _rb;
    [SerializeField] private float _forceJump;
    private bool _isgrounded;
    private bool _canJump;

    private void Awake()
    {
        // Llamada al Animator del gameObject seleccionado
        _animation = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
    }

    // Médoto al cargo de las físicas.
    private void FixedUpdate()
    {
        LaunchRaycast();
        if (_canJump == true)
        {
            // Pasa a volverse "false" para que el salto no sea eterno
            _canJump = false;
            // Llamada al método que empuja al salto
            Jump();
        }

    }

    // Método al cargo de las teclas
    void Update()
    {
        // Llamada a los métodos al iniciar
        InputPlayer();
        Move();
        Turn();
        Animating();
        CanJump();
    }

    private void InputPlayer()
    {
        // Uso de teclas A D | < > para movimiento
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        // Aplicación de eje vertical a Translate
        transform.Translate(Vector3.forward * _speed * _vertical * Time.deltaTime);
    }

    private void Turn()
    {
        // Aplicación eje horizontal a Rotate
        transform.Rotate(Vector3.up * _turnSpeed * _horizontal * Time.deltaTime);
    }
    private void LaunchRaycast()
    {
        // El "Raycast" comienza desde la posición del transform (Player)
        _ray.origin = transform.position;
        // El "Raycast" se extiende hacia abajo (por ende, en negativo)
        _ray.direction = -transform.up;

        if (Physics.Raycast(_ray, out _hit, _rayLenght, _rayMask))
        {
            Debug.Log("Estoy tocando el suelo");
            _isgrounded = true;
        }
        else
        {
            Debug.Log("NO estoy tocando el suelo");
            _isgrounded = false;
        }
    }

    private void Jump()
    {
        _rb.AddForce(Vector3.up * _forceJump);
    }

    // Método para activar el salto
    private void CanJump()
    {
        // Si se pulsa espacio Y el bool es verdadero:
        if(Input.GetKeyDown(KeyCode.Space) && _isgrounded == true)
        {
            _canJump = true;
        }
    }

    private void Animating()
    {
        if(_vertical != 0)
        {
            _animation.SetBool("IsMoving", true);
        }

        else
        {
            _animation.SetBool("IsMoving", false);
        }

    }
}
