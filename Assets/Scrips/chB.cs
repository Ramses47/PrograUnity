using UnityEngine;

public class chB : ClasePadre
{
    
    public void FuncionPadre1()
    {
        Debug.Log("aaaaaaaa");
    }
    public void RestaScore(int points)
    {
        //FuncionPadre1();

        Singleton.instance.score -= points;
        Debug.Log(Singleton.instance.score);
    }

    public override void FuncionPadre2()
    {
        Debug.Log("Fucion CHAAA");
    }
}
