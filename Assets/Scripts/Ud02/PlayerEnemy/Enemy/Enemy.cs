using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider infoAccess)
    {
        // Destruir "Enemy" ante contacto con la espada en modo ("Attack")
        if (infoAccess.CompareTag("PlayerAttack"))
        {
            Destroy(gameObject);
        }
    }
}
