using UnityEditor;
using UnityEngine;

public class ClonEgg : MonoBehaviour
{
    /* Zona de variables globales. En serializado para
      editar o probar combinaciones desde el inspector */

    [Header("Elements")]
    [SerializeField] private GameObject _egg;
    [SerializeField] private Transform _posRotBunny;

    [Header("Physics")]
    [SerializeField] private float _thrustZ;
    [SerializeField] private float _thrustY;

    void Start()
    {
        _thrustY = 3f;
        _thrustZ = 3f;
    }

    void Update()
    {
        // Llamada al input que activará el método de clonado de huevos
        InputCreateEggs();
    }

    private void InputCreateEggs()
    {
        /* Activación del método al pulsar el botón izdo (0)
           El clic llama al método de clonación del huevo */
        if (Input.GetMouseButtonDown(0))
        {
            ClonEggs();
        }

    }

    private void ClonEggs() // Método para el clonado del GameObject "Egg"
    {
         // Instancia del prefabricado "Egg"
         GameObject clonEgg = Instantiate(_egg, _posRotBunny.position, _posRotBunny.rotation);

         // Rigidbody de cada clon de huevo
         Rigidbody rbEgg = clonEgg.GetComponent<Rigidbody>();

         /* Destrucción de los huevos a los 15 segundos de la instanciación
            para no saturar la plataforma */
         Destroy(clonEgg, 15.0f);

         // Fuerza de "Egg" hacia arriba" en eje GLOBAL (de la escena)
         rbEgg.AddForce(Vector3.up * _thrustY);

         // Fuerza de "Egg" hacia adelante en eje LOCAL (del PosRot)
         rbEgg.AddForce(transform.forward * _thrustZ);
    }

}
