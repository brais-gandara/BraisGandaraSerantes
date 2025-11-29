using UnityEngine;

public class Activated : MonoBehaviour
{
    // Variables globales
    [SerializeField] private GameObject _myCamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ActivateCamera();
        
    }
    private void ActivateCamera()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _myCamera.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _myCamera.SetActive(true);
        }
    }
}
