using UnityEngine;

public class FSM_Manager : MonoBehaviour
{
    FCM_1 actualState;
    public FCM_2 idle = new FCM_2();
    public FCM_3 Walk = new FCM_3();
    public FSM_Sleep sleep = new FSM_Sleep();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        actualState = idle;
        actualState.Enter(this);
    }

    // Update is called once per frame
    void Update()
    {
        actualState.Stay(this);
    }

    public void SwitchState(FCM_1 newState)
    {
        actualState.Exit(this);
        actualState = newState;
        actualState.Enter(this);
    }
}
