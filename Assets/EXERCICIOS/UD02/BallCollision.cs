using UnityEngine;

public class BallCollision : MonoBehaviour
{
    /*[SerializeField] private Material _mat;
    private void OnCollisionEnter(Collision infoCollision)
    {
        Debug.Log("Me ha dado " + infoCollision.gameObject.name);

        // Acceso ao collider co que se choca a bala para ver se etiqueta = enemy
        if (infoCollision.collider.CompareTag("Enemy"))
        {
            // Cambio de material del cubo
            // Accedo a componente "renderer" y a la propiedad "material"
            infoCollision.gameObject.GetComponent<Renderer>().material = _mat;
        }
    }*/

    
    // Acceder á info do collider
    private void OnTriggerEnter(Collider infoAccess)
    {
        // Aviso en consola para ver con qué objeto se colisiona
        Debug.Log("He colisionado colisionando con " + infoAccess.gameObject.name);

        if (infoAccess.CompareTag("Enemy"))
        {
            Destroy(infoAccess.gameObject);
        }
    }
}
