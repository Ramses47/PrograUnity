using UnityEngine;

public delegate void evento();

public class Pruebas : MonoBehaviour
{
    //Eventos y Delegates
    //Delegate = Almacenamiento de funciones 

    public event evento eventShoot;

    public void funcShoot()
    {
        if(eventShoot != null)
        {
            eventShoot.Invoke();
        }
        Debug.Log("Evento PrincipaL dice: ");
    }

}
