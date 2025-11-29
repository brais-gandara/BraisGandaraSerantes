using UnityEngine;

public class MouseEvents : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("Actúo cuando clic botón izdo sobre collider");
    }

    private void OnMouseOver()
    {
        Debug.Log("Actúo cuando ratón está sobre collider");
    }

    private void OnMouseEnter()
    {
        Debug.Log("Actúo cuando entro en collider");

    }
    private void OnMouseExit()
    {
        Debug.Log("Actúo cuando salgo en collider");

    }
    private void OnMouseDrag()
    {
        Debug.Log("Actúo cuando arrastro rátón por collider");

    }
}

