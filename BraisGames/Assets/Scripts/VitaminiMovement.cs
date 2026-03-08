using System.Runtime.CompilerServices;
using UnityEditor.Tilemaps;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class VitaminiMovement : MonoBehaviour
{
    [Header("Speed")]
    [SerializeField] private float _speed; // Velocidade
    [SerializeField] private float _smoothTime; // EASE IN: Tempo que tarda en chegar a _speed

    private Vector2 _targetVelocity; // Velocidade á que mover o px
    private Vector2 _dampVelocity; //

    public Rigidbody2D Rb; // para rb. Pública para script de ataque
    private Animator _anim; // Para animacións
    private SpriteRenderer _spriteRenderer; // Para eixo X

    [Header("Jump")]
    [SerializeField] private float _jumpForce; // Forza de salto
    private bool _jumpPress; // Para saber se a tecla de salto está ou non premida

    [Header("Raycast")]
    [SerializeField] private Transform _groundCheck; // Punto orixe Raycast (pés)
    [SerializeField] private LayerMask _groundLayer; // Capa "chan"
    [SerializeField] private float _rayLenght; // Lonxitude Raycast
    public bool IsGrounded;    /* Bool para saber se toca ou non o chan
                                   Pública porque outro script depende dela */

    [Header("Acorn")]
    [SerializeField] private int _numAcorn; // número de bellotas
    [SerializeField] private TextMeshProUGUI _textAcornUI; // Texto

    private void Awake()
    {
        _jumpPress = false; // Para asegurar de que o bool non se marca como true por accidente.
        Rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        VitaminiMove();
        CanJump(); // Chamada á física para o chimpo
        RaycastGrounded(); // Chamada á física para o Raycast
        ChangeGravity(); // Chamada ao cambio de gravidade no salto.


    }

    private void CanJump() // Método que chama a Jump se o bool é "true"
    {
        if(_jumpPress == true) // Só se admite o salto se o bool está en "true"
        {
            Jump();
        }

    }

    private void Jump()
    {
        _jumpPress = false; // Unha vez se salta, o bool pasa a "false" para non estendelo indefinidamente
        Rb.AddForce(Vector2.up * _jumpForce); // Multiplicación do eixo X x forza escollida
    }

    private void RaycastGrounded()
    {
        IsGrounded = Physics2D.Raycast(_groundCheck.position, Vector2.down, _rayLenght, _groundLayer); // Bool necesario para actualizar o Upd)
        Debug.DrawRay(_groundCheck.position, Vector2.down * _rayLenght, Color.red);
    }

    void Update()
    {
        VitaminiInput();
    }

    private void VitaminiInput()
    {
        // Teclas A/D/</>
        float horizontal = Input.GetAxis("Horizontal");
        // Asignación do Input ao eixo X
        _targetVelocity = new Vector2(horizontal * _speed, Rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded == true)
        {
            _jumpPress = true; // bool que activa CanJump()
        }

        Animating(horizontal); // horizontal non existe en Animating, pásalle por PASO POR PARÁMETRO
        Flip(horizontal); // Chámase dende InputsPlayer porque debe funcionar cando se está en movemento

    }

    // Reinicia velocidade se recibe dano
    public void ResetVelocity()
    {

        _targetVelocity = Vector2.zero;

    }

    private void VitaminiMove()
    {
        // vel inicial, vel obxectivo, tempo desexado. REF recalcula o cambio cad asegundo
        Rb.linearVelocity = Vector2.SmoothDamp(Rb.linearVelocity, _targetVelocity, ref _dampVelocity, _smoothTime);
    }

    private void Animating(float h) // Chámaselle ao float horizontal de "VitaminiInput()" e renoméase
    {
        if(h != 0.0f)
        {
            _anim.SetBool("IsRunning", true);

        }

        else
        {
            _anim.SetBool("IsRunning", false);
        }

        _anim.SetBool("IsJumping", !IsGrounded);
    }

    private void Flip(float h) // chámase de novo ao float "horizontal" dende "InputsPlayer()":
    {
        if(h > 0.0f) // Se "horizontal" é positivo, non se xira.
        {
            _spriteRenderer.flipX = false;
        }
        else if(h < 0.0f) // Se "horizontal" é negativo, xírase.
        {
            _spriteRenderer.flipX = true;
        }
    }

    private void ChangeGravity()
    {
        if(Rb.linearVelocity.y < 0.0f) // Se o salto (eixo Y) está activo, cámbiase a gravidade
        {
            Rb.gravityScale = 1.5f;

        }
        else
        {
            Rb.gravityScale = 1.0f;
        }
    }

    private void OnCollisionEnter2D(Collision2D infoCollision) // Destrucción da landra
    {

        if (infoCollision.collider.CompareTag("Acorn")) // Se recoñece a etiqueta Landra, destrúea.
        {
           /* Comézase especificando o n.º de landras para que a xogadora
              saiba que ten que facer */
            _textAcornUI.text = "Landras perdidas: " + _numAcorn.ToString();
            Destroy(infoCollision.collider.gameObject); // Destrucción landra
            _numAcorn--; // Réstase -1 landra por cada interacción
            _textAcornUI.text = "Landras perdidas: " + _numAcorn.ToString(); // Vólcase o núm no texto

            if(_numAcorn == 0)
            {
                GetNewScene();
            }
        }
        
    }

    private void GetNewScene()
    {
        SceneManager.LoadScene(0); // Pode poñerse ("nomeEscena") tamén
    }
}
