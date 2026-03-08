using UnityEngine;
using UnityEngine.UI;

public class VitaminiHealth : MonoBehaviour
{
    // Zona variables globales
    [Header("Health")]
    [SerializeField] private float _maxHealth; // Vida máxima de Vitamini
    [SerializeField] private float _currentHealth; // Vida actual de Vitamini

    [Header("UI")]
    [SerializeField] private Image _acornHealth; // Imaxe da vida
    [SerializeField] private float _healthAmount; // Cantidade "baleirada" da imx

    [Header("Death")]
    [SerializeField] private float _forceJumpDeath; // Salto forzado da morte
    private Animator _anim; // Animator
    private VitaminiMovement _vitaminiMovementScript; // Método de outro script

    private void Awake()
    {
        _anim = GetComponent<Animator>(); // Chamada ao Animator
        _vitaminiMovementScript = GetComponent<VitaminiMovement>();
        _currentHealth = _maxHealth; // Comeza coa saúde máxima
    }

    public void TakeDamage(float amount)
    {
        /* Cada enimigo pasará x cantidade de dano por PASO PARÁMETRO
           Pero o método NON se activa se está ferida ou en negativos */

        // Se está ferida ou en negativos, non se activa o método
        if(_anim.GetBool("IsHurt") == true || _currentHealth <= 0.0f)
        {
            return;
        }

        _currentHealth -= amount; // Resta do dano
        // Vida divídese entre vida actual e vida máxima
        _acornHealth.fillAmount = _currentHealth / _maxHealth;
        _anim.SetBool("IsHurt", true); // Actívase anim. morte
        _vitaminiMovementScript.ResetVelocity(); // Reiníciase vel dende script

        if(_currentHealth <= 0.0f)
        {
            Death();
            return;
        }

        // Invócase o método (HurtToFalse) que desactiva "IsHurt" ao segundo
        Invoke("HurtToFalse()", 3.0f);   }

    private void HurtToFalse()
    {
        _anim.SetBool("IsHurt", false); // Desactívase "IsHurt"
    }

    private void Death()
    {
        GetComponent<CircleCollider2D>().enabled = false; // Desactívase
        GetComponent<Rigidbody2D>().AddForce(Vector2.down * _forceJumpDeath);
    }
}
