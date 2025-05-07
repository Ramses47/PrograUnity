
using UnityEngine;

public class EventsB : MonoBehaviour
{
    public Pruebas main = new Pruebas();

    private void OnEnable()
    {
        main.eventShoot += ShootB;
    }
    public void ShootB()
    {
        Debug.Log("Shoot B!");
    }
}
