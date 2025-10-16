using UnityEngine;

public class Shop : MonoBehaviour
{
    // Variables globales
    // Productos que añadir a la cesta (Públicos porque un usuario o usuaria deben poder introducirlos)
    public int Broccoli;
    public int Potatoes;
    // Booleanos para activar el cambio de número
    public bool ChangeBroccoliNumber;
    public bool ChangePotatoNumber;
    // Casilla para sumar o restar al producto seleccionado arriba
    public int AddItem;
    public int SubtractItem;

    void Start()
    {
        // Llamada al apartado de operaciones (suma o resta)
        Operations();
    }

    private void Operations()
    {
        // Llamada por parámetro a cada método (uno para la suma, otro para la resta)
        if(AddItem > 0)
        {
            GetAddition(Broccoli, Potatoes, AddItem);
        }
        else if (SubtractItem > 0)
        {
            GetSubtraction(Broccoli, Potatoes, SubtractItem);
        }

    }

    private void GetAddition(int broccoli, int potatoes, int addItem)
    {
        // Llamada a la operación de suma con los brócolis
        if(ChangeBroccoliNumber == true) {
        int result = broccoli + addItem;
        Debug.Log("El número total de brócolis comprados tras la suma es: " + result);
        }
        // Llamada a la operación de suma con las patatas
        else if (ChangePotatoNumber == true)
        {
            int result = potatoes + addItem;
            Debug.Log("El número total de patatas compradas tras la suma es: " + result);
        }
    }
    private void GetSubtraction(int broccoli, int potatoes, int subtractItem)
    {
        // Llamada a la operación de resta con los brócolis
        if (ChangeBroccoliNumber == true)
        {
            int result = broccoli - subtractItem;
            Debug.Log("El número total de brócolis comprados tras la resta es: " + result);
        }
        // Llamada a la operación de resta con las patatas
        else if (ChangePotatoNumber == true)
        {
            int result = potatoes - subtractItem;
            Debug.Log("El número total de patatas compradas tras la resta es: " + result);
        }
    }
}
