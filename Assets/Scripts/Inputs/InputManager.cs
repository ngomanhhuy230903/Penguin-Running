using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance { get { return  instance; } }

    //action schemes
    private RunnerInputAction actionScheme;
    //Configurations
    [SerializeField] private float sqrSwipeDeadzone = 50f;
    #region public properties
    public bool Tap { get { return tap; } }
    public Vector2 TouchPosition { get { return touchPosition; } }
    public bool SwipeLeft { get { return swipeLeft; } }
    public bool SwipeRight { get { return swipeRight; } }     
    public bool SwipeUp { get { return swipeUp; } }
    public bool SwipeDown { get { return swipeDown; } }
    #endregion
    #region privates
    private bool tap;
    private Vector2 touchPosition;
    private Vector2 startDrag;
    private bool swipeLeft;
    private bool swipeRight;
    private bool swipeUp;
    private bool swipeDown;
    #endregion
    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
        SetupControl();
    }
    private void LateUpdate()
    {

        ResetInputs();
    }

    private void ResetInputs()
    {
        tap = swipeDown = swipeLeft = swipeRight = swipeUp = false;
    }

    private void SetupControl()
    {

       actionScheme = new RunnerInputAction();
       actionScheme.GamePlay.Tap.performed += ctx => OnTap(ctx);
       actionScheme.GamePlay.TouchPosition.performed += ctx => OnPosition(ctx);
       actionScheme.GamePlay.StartDrag.performed += ctx => OnStartDrag(ctx);
       actionScheme.GamePlay.EndDrag.performed += ctx => OnEndDrag(ctx);
    }

    private void OnEndDrag(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
    {
        Vector2 delta = touchPosition - startDrag;
        float sqrDistance = delta.sqrMagnitude;
        //confirm swipe
        if (sqrDistance > sqrSwipeDeadzone)
        {
            if (Mathf.Abs(delta.x) > Mathf.Abs(delta.y))
            {
                if (delta.x < 0)
                {
                    swipeLeft = true;
                }
                else
                {
                    swipeRight = true;
                }
            }
            else
            {
                if (delta.y < 0)
                {
                    swipeDown = true;
                }
                else
                {
                    swipeUp = true;
                }
            }
        }
        startDrag = Vector2.zero;
    }

    private void OnStartDrag(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
    {
        startDrag = touchPosition;
    }

    private void OnPosition(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
    {
        touchPosition = ctx.ReadValue<Vector2>();
    }

    private void OnTap(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
    {
        tap = true;
    }
    public void OnEnable()
    {
        actionScheme.Enable();
    }
    public void OnDisable()
    {
        actionScheme.Disable();
    }
}
