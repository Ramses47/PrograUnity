using UnityEngine;

public class FCM_3 : FCM_1
{
    public override void Enter(FSM_Manager state)
    {
        Debug.Log("Enter_3");
    }

    public override void Stay(FSM_Manager state)
    {
        Debug.Log("Stay_3");
        time += Time.deltaTime;
        if (time >= 2)
        {
            state.SwitchState(state.sleep);
            time = 0;
        }
    }
    public override void Exit(FSM_Manager state)
    {
        Debug.Log("Exit_3");
    }
}

