using Unity.VisualScripting;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    // Zona de variables globales
    private Animator _animator;
    [SerializeField] private Collider _colliderAttack;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Llamada al input del ataque (la tecla)
        InputPlayerAttack();
    }


    private void InputPlayerAttack()
    {
        if(Input.GetMouseButtonDown(0))
        {
            // Llamada al botón que activa el ataque
            BaseAttack();
        }
    }
    
    private void BaseAttack()
    {
        // Llamada al trigger que activa el cambio de animación en ataque
        _animator.SetTrigger("Attack");
    }

    private void OnEnableCollider()
    {
        // Se habilita el componente para el collider de la espada
        _colliderAttack.enabled = true;
    }
    private void OnDisableCollider()
    {
        // Se deshabilita el componente para el collider de la espada
        _colliderAttack.enabled = false;
    }

    //private void OnTriggerEnter(Collider infoAccess)
    //{
    //    // Destruir "Enemy" ante contacto con la espada en modo ("Enemy")
    //    if (infoAccess.CompareTag("Enemy"))
    //    {
            
    //        Destroy(gameObject("Enemy"));
    //    }
    //}

    //private OnCollisionEnter(Collider infoAccess)
    //{
    //    // Condicional: Si se detecta un obj con etiqueta "Enemigo" y el collider de ataque está activado.
    //    if (infoAccess.CompareTag("Enemy") && _colliderAttack.enabled == true)
    //    {
    //        // infoAccess hace referencia a "Enemy"
    //        Destroy(infoAccess.gameObject);
    //    }
    //}
}
