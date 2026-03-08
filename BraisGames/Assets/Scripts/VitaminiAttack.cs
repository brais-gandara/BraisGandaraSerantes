using UnityEngine;

public class VitaminiAttack : MonoBehaviour
{
    // Zona variables globales
    [SerializeField] private VitaminiMovement _vitaminiMovementScript;
    [SerializeField] private float _jumpForce;


    private void OnCollisionEnter2D(Collision2D infoCollision)
    {
        // Se se colisiona cun gameObject de etiqueta "Ant"...
        if (infoCollision.collider.CompareTag("Ant"))
        {
            // Chamada a método e aviso de con que gameObject se colisiona
            AttackEnemy(infoCollision.gameObject);
        }
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void AttackEnemy(GameObject enemy)
    {
        // Se está no chan, non se activa.
        if(_vitaminiMovementScript.IsGrounded)
        {

            return;

        }

        // Se chimpa, accédese ao Rb e créase unha forza
        _vitaminiMovementScript.Rb.AddForce(Vector2.up * _jumpForce);

        enemy.GetComponent<Animator>().SetTrigger("Death");
        Destroy(enemy, 0.3f);

    }
}
