using UnityEngine;

public class EventsA : MonoBehaviour
{
    public Pruebas main = new Pruebas();

    private void OnEnable()
    {
        main.eventShoot += ShootA;
    }
    void Start()
    {
        main.funcShoot();
    }
    public void ShootA()
    {
        Debug.Log("Shoot A!");
    }


}
