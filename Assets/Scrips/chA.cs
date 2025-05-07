using UnityEngine;

public class chA : ClasePadre, IDamage
{

   public void FuncionPadre1()
    {
        Debug.Log("holaaaaaaaaaaaaaaaaaa");
    }

    public void AddScore(int points)
    {
        //FuncionPadre1();

        Singleton.instance.score += points;
        Debug.Log(Singleton.instance.score);
    }

    public override void FuncionPadre2()
    {
        Debug.Log("Fucion CHA");
    }

    void IDamage.TakeDamage()
    {
        Debug.Log("");
    }
}
