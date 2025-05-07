using UnityEngine;

public class FCM_2 : FCM_1
{
    public override void Enter(FSM_Manager state)
    {
        Debug.Log("Enter_2");
    }

    public override void Stay(FSM_Manager state)
    {
        Debug.Log("Stay_2");

        time += Time.deltaTime;
        if(time >= 2)
        {
            state.SwitchState(state.Walk);
            time = 0;
        }
    }
    public override void Exit(FSM_Manager state)
    {
        Debug.Log("Exit_2");
    }
}
