using UnityEngine;

public class FSM_Sleep : FCM_1
{
    public override void Enter(FSM_Manager state)
    {
        Debug.Log("Enter_Slep");
    }

    public override void Stay(FSM_Manager state)
    {
        Debug.Log("Stay_Slep");

        time += Time.deltaTime;
        if (time >= 2)
        {
            state.SwitchState(state.idle);
            time = 0;
        }
    }
    public override void Exit(FSM_Manager state)
    {
        Debug.Log("Exit_Sleep");
    }
}
