using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningState : BaseState
{
    public override void Construct()
    {
        motor.verticalVelocity = 0.0f;
    }
    public override Vector3 ProcessMotion()
    {
        Vector3 m = Vector3.zero;
        m.x = motor.SnapToLane();
        m.y = -1.0f;
        m.z = motor.baseRunSpeed;
        return m;
    }
    public override void Transition()
    {

        if (InputManager.Instance.SwipeLeft)
        {
            Debug.Log("Swipe Left");
            motor.ChangeLane(-1);
        }
        if (InputManager.Instance.SwipeRight)
        {
            Debug.Log("Swipe Right");
            motor.ChangeLane(1);
        }
        if(InputManager.Instance.SwipeUp && motor.isGrounded)
        {
            Debug.Log("Swipe Up");
            motor.ChangeState(GetComponent<JumpingState>());
        }
        if(!motor.isGrounded)
        {
            motor.ChangeState(GetComponent<FallingState>());
        }
    }

}
