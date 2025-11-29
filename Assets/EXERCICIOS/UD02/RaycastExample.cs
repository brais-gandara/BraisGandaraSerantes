using UnityEngine;

public class RaycastExample : MonoBehaviour
{
    // Zona variables globales
    private Ray _ray;
    // Gardar info entre raycast e collider de gameObj
    private RaycastHit _hit;
    [SerializeField] private float _rayLenght;
    // Detecta só os elementos que estean na capa escollida
    private LayerMask _enemyMask;

    void Update()
    {
        // Dende onde empeza e como se despraza (seguindo o transform)
        _ray.origin = transform.position;
        _ray.direction = transform.forward;

        // como só devolve bools, "out" forza a devolver a info e almacenala en "_hit"
        if (Physics.Raycast(_ray, out _hit, _rayLenght, _enemyMask))
        {
            Debug.Log("Socorrooo" + _hit.collider.name); // nome do gameObj co que choca
            Debug.Log(_hit.distance); // distancia entre os dous elementos

            // Cando o Rigidbody toque o raio, saltará esta distancia
            _hit.collider.GetComponent<Rigidbody>().AddForce(Vector3.up * 300.0f);
        }

        // Debuxar a liña + 
        Debug.DrawRay(_ray.origin, _ray.direction * _rayLenght, Color.yellow);
        
    }
}
