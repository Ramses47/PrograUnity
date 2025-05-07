using UnityEngine;

public class Singleton : MonoBehaviour
{

    public static Singleton instance;
    public int score = 0;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this);
        }
    }
}
