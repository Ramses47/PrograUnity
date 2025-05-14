using UnityEngine;

public class Lines : MonoBehaviour
{
    LineRenderer line;
    public Transform[] objs; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        line = GetComponent<LineRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i< objs.Length; i++)
        {
            line.SetPosition(i, objs[i].position);
        }
        
    }
}
