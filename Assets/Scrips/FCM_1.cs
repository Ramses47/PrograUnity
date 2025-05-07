using UnityEngine;

public abstract class FCM_1 
{

    public abstract void Enter(FSM_Manager state);

    public abstract void Stay(FSM_Manager state);

    public abstract void Exit(FSM_Manager state);

    protected float time;
}
