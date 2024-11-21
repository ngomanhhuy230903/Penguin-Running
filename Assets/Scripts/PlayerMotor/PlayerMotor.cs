using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    [HideInInspector] public Vector3 moveVector;
    [HideInInspector] public float verticalVelocity;
    [HideInInspector] public bool isGrounded;
    [HideInInspector] public int currentLane;

    public float distanceInBetweenLanes = 4.0f;
    public float baseRunSpeed = 5.0f;
    public float baseSidewaySpeed= 10.0f;
    public float gravity = 14.0f;
    public float terminalVelocity = 20.0f;

    public CharacterController controller;
    private BaseState state;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        state = GetComponent<RunningState>();
        state.Construct();
    }
    private void Update()
    {
        UpdateMotor();
    }
    private void UpdateMotor()
    {
        //check if we're is grounded
        isGrounded = controller.isGrounded;
        //how should we moving right now? base on state 
        moveVector = state.ProcessMotion();
        //are we trying to change state
        state.Transition();
        //move the player
        controller.Move(moveVector * Time.deltaTime);
    }
    public float SnapToLane()
    {
        float r = 0.0f;
        if(transform.position.x != currentLane * distanceInBetweenLanes)
        {
            float deltaToDesiredPosition= (currentLane * distanceInBetweenLanes) - transform.position.x;
            r = (deltaToDesiredPosition > 0) ? 1 : -1;
            r *= baseSidewaySpeed;
            float actualDistance = r * Time.deltaTime;
            if(Mathf.Abs(actualDistance) > Mathf.Abs(deltaToDesiredPosition))
            {
                r = deltaToDesiredPosition * (1 / Time.deltaTime);
            }
            else
            {

                r = 0;
            }          
        }
        return r;
    }
    public void ChangeLane(int direction)
    {
        currentLane = Mathf.Clamp(currentLane + direction, -1, 1);
        Debug.Log("Current Lane: " + currentLane);
    }
    public void ChangeState(BaseState newState)
    {
        state.Destruct();
        state = newState;
        state.Construct();
    }
    public void ApplyGravity()
    {
        verticalVelocity -= gravity * Time.deltaTime;
        if(verticalVelocity < -terminalVelocity)
        {
            verticalVelocity = -terminalVelocity;
        }
    }
}
