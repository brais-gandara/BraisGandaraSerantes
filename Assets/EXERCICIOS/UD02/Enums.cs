using UnityEngine;

public class Enums : MonoBehaviour
{
    // Zona de variables globales
    [SerializeField]
    private Space _mySpace;
    [SerializeField]
    private KeyCode _myKeyCode;
    [SerializeField]
    private ForceMode _myForceMode;
    [SerializeField] // para velocidade da rotación, NON dos graos de rotación
    private float _turnSpeed;
    [SerializeField] // para velocidade dos graos de rotación
    private float _speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) // Ao premer a W, xira o eixo Z? á velocidade marcada no Inspector
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)) // xirar á esquerda (Vector.right pero con rotación; negativa, contra as agullas do rel)
        {
            transform.Rotate(-Vector3.up * _turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) // xirar á dereita (Vector.right pero con rotación; positiva, agullas rel)
        {
            transform.Rotate(Vector3.up * _turnSpeed * Time.deltaTime);
        }
    }
}
