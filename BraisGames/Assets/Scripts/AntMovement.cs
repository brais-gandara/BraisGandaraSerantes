using UnityEngine;

public class AntMovement : MonoBehaviour
{
    // Variables globais
    [SerializeField] private Transform[] _wayPointsArray; // Puntos de patrulla da formiga
    [SerializeField] private Vector2[] _positionsArray; // Pos da patrulla (cóllese "position" de _wayPointsArray)
    private Vector3 _posToGo; // Pos para que a formiga vaia dun caixón a outro. DEBE SER V3 e non V2
    private int _index; // Inicialízase en 0 cando o método necesite un núm enteiro
    private SpriteRenderer _spriteRenderer; // Para o flip do sprite
    private Animator _anim;

    [Header("Detection")]
    [SerializeField] private float _speedWalk; // Velocidade da formiga
    [SerializeField] private float _speedAttack;
    [SerializeField] private float _speedAnimation;

    [SerializeField] private GameObject _vitamini;
    [SerializeField] private float _distanceToVitamini;


    private float _speed; // Velocidade da formiga. Non serializada porque se fai no Awake

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _anim = GetComponent<Animator>();
        _speed = _speedWalk;

        // Inicialízase array de posicións: Tantas posicións como lonxitude teña o array _wayPointsArray
        _positionsArray = new Vector2[_wayPointsArray.Length];
        /* Bucle para facer un recorrido polo outro. Cando faga un recorrido polo
         * _wayPoint anterior, énchense as posicións do novo array */
        for (int i = 0; i < _wayPointsArray.Length; i++)
        {
            _positionsArray[0] = _wayPointsArray[i].position;
        }

        // Cóllese o contido de _positionsArray na caixa 0, asígnaselle a _posToGo
        _posToGo = _positionsArray[0];
    }
    void Update()
    {

        // Se se detecta _vitamini a x distancia, realiza AttackPlayer()
        Debug.DrawLine(transform.position, _posToGo, Color.green);
        if(Vector2.Distance(transform.position, _vitamini.transform.position) <= _distanceToVitamini)
        {
            AttackPlayer();
        }
        else
        {
            ChangeTargetPos();
        }

        /* MovementTowards = muda valor do vector dende punto actual (t.positon)
         * ao punto desexado (_posToGo) */
        transform.position = Vector3.MoveTowards(transform.position, _posToGo, _speed * Time.deltaTime);

        AntFlip();
    }

    private void ChangeTargetPos()
    {
        _speed = _speedWalk;
        _anim.speed = 1.0f;

        // Condicional para saber se está no punto saída/chegada
        if(transform.position == _posToGo)
        {
            // Se está no último punto do "array", reiníciase a 0
            if(_index == _positionsArray.Length - 1)
            {
                _index = 0;
            }
            // Se NON está no último punto do "array", pasa ao seguinte caixón
            else
            {
                _index++;
            }
            
            // Asignación de novo punto de array a _posToGo -> Caixón 1, elemento 0
            _posToGo = _positionsArray[_index];
        }

    }

    private void AntFlip()
    {
        if(_posToGo.x > transform.position.x)
        {
            // Cara a dereita
            _spriteRenderer.flipX = true;
        }
        else if (_posToGo.x < transform.position.x)
        {
            // Cara a esquerda
            _spriteRenderer.flipX = false;
        }
    }

    public void AttackPlayer()
    {
        _speed = _speedAttack;
        // Dentro do animator, muda a velocidade se ve a Vitamini
        _anim.speed = _speedAnimation;
        _posToGo = new Vector2(_vitamini.transform.position.x, _posToGo.y);
    }

    // Método para detectar a Vitamini e facer dano
    private void OnCollisionEnter2D(Collision2D infoCollision)
    {
        // Para atacar: etiqueta "Player" + estar no chan
        if (infoCollision.collider.CompareTag("Player") &&
            infoCollision.collider.GetComponent<VitaminiMovement>().IsGrounded == true)
        {
        // Se se cumple: entra en VitaminiHealth e envía x puntos a método
            infoCollision.collider.GetComponent<VitaminiHealth>().TakeDamage(15.0f);
        }
        
    }
}
