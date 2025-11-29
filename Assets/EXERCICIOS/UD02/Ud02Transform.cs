using UnityEngine;

public class Ud02Transform : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}
