using UnityEngine;
using UnityEngine.UIElements;

public class CameraFollow : MonoBehaviour
{
    // Zona de variables globales
    [SerializeField] private Transform _target;

    [Header("Vectors")]
    // Velocidad de seguimiento de la cámara
    [SerializeField] private float _smoothing;
    // Distancia entre cámara y "Player"
    [SerializeField] private Vector3 _offset;

    void Start()
    {
        _offset = transform.position - _target.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        // Posición a la que se debe mover la cámara
        Vector3 desiredPosition = _target.position + _offset;

        // Movimiento de cámara
        transform.position = Vector3.Lerp(transform.position, desiredPosition, _smoothing * Time.deltaTime);


    }
}
