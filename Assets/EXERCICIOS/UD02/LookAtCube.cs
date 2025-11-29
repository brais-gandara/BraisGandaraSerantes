using UnityEngine;

public class LookAtCube : MonoBehaviour
{
    // Variables globales
    [SerializeField] private Transform _myCube;

    void Update()
    {
        LookCube(); // Chamada ao método        
    }
    private void LookCube()
    {
        transform.LookAt( _myCube );

    }
}
