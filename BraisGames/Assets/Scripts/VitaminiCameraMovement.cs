using UnityEngine;

public class VitaminiCameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _player;
    private Vector3 _offset; // Distancia inicial entre obxectivo-cámara
    private Vector3 _smoothDampVelocity;
    [SerializeField] private float _smoothTargetTime; // Transición de chegada ao obxectivo

    private void Awake()
    {
        // Cálculo inicial entre posición de Vitamini e cámara
        _offset = transform.position - _player.position;
    }

    void Update()
    {
        CameraMove();
        
    }

    private void CameraMove()
    {

        transform.position = Vector3.SmoothDamp(transform.position,
            _player.position + _offset, ref _smoothDampVelocity, _smoothTargetTime);

    }
}
