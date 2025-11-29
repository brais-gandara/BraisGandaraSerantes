using UnityEngine;

public class ComponentGet : MonoBehaviour
{
    // Variables globales
    private Light _myLight; // Para activar PROPIOS COMPOÑENTES. En canto se lle chama, se pode acceder ao compoñente. Mesmo nome do sistema
    // Para activar compoñentes de OUTROS OBX
    [SerializeField] private BoxCollider _myCubeCollider;

    private void Awake()
    {
        // Inicialización de "Light" porque o "GameObject" ten este compoñente
        // Sempre que se poida inicializar en compoñente mellor
        _myLight = GetComponent<Light>();
    }
    void Start()
    {
        _myLight.enabled = true; // Está activo
        _myCubeCollider.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
