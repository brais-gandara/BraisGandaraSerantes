using UnityEngine;

public class Week : MonoBehaviour
{
    // Variables globales
    [SerializeField]
    private int _dayNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsDayWeek();
    }

    // Update is called once per frame
    private void IsDayWeek()
    {
        switch (_dayNumber)
        {
            case 1:
                Debug.Log("El mes " + _dayNumber + " corresponde con enero.");
                break;
            case 2:
                Debug.Log("El mes " + _dayNumber + " corresponde con febrero.");
                break;
            case 3:
                Debug.Log("El mes " + _dayNumber + " corresponde con marzo.");
                break;
            case 4:
                Debug.Log("El mes " + _dayNumber + " corresponde con abril.");
                break;
            case 5:
                Debug.Log("El mes " + _dayNumber + " corresponde con mayo.");
                break;
            case 6:
                Debug.Log("El mes " + _dayNumber + " corresponde con junio.");
                break;
            case 7:
                Debug.Log("El mes " + _dayNumber + " corresponde con julio.");
                break;
            default:
                Debug.Log("El número " + _dayNumber + " no corresponde a ningún mes estipulado...");
                break;
        }
    }
}