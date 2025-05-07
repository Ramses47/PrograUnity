using UnityEngine;

public abstract class ClasePadre : MonoBehaviour 
{
     public virtual void FuncionPadre1()
     {
         Debug.Log("hola UwU");
     }

    public abstract void FuncionPadre2();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
