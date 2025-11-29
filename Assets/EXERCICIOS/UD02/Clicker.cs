using UnityEngine;

public class Clicker : MonoBehaviour
{
    // Variables globales
    [SerializeField] private float _thrust;
    [SerializeField] private Rigidbody _rb;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        _rb.AddForce(transform.up * _thrust, ForceMode.Force); // ForceMode.Force pode obviarse/borrarse
    }
}
