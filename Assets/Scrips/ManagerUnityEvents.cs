using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ManagerUnityEvents : MonoBehaviour
{
    public UnityEvent evento;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        evento.AddListener(FuncionparaElEventoDeUnity);

        evento.Invoke();
    }

    public void FuncionparaElEventoDeUnity()
    {
        Debug.Log("Hola mundo");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    // 1.- Singleton
    // Interfaces
    // Funciones virtuales y abstractas
}
