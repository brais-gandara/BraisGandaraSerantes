using UnityEngine;

public class RandomNumber : MonoBehaviour
{
    // Variables globales (privadas porque no requieren uso desde Inspector)
    private string[] _futureArray = { "Comerás patatas mañana", "Lloverá sobre tu casa como no estudies para el examen", "Te partirá un rayo si no regalas flores", "Atropellarás una hormiga por accidente", "Soplarás velas de cartón o tendrás mala suerte" };

    void Start()
    {
        /* Selección del aleatorio dentro de valores del array (de 0 a 5 porque el último no se incluye:
         * la aleatoriedad se da entre 0-4 elementos) */

        Debug.Log("La predicción el futuro de hoy es: " + _futureArray[Random.Range(0,5)] + ".");
    }
}
