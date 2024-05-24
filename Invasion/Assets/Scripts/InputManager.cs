using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


[DefaultExecutionOrder(-1)]
public class InputManager : MonoBehaviour
{
    private Camera mainCamera;
    private TouchControls TouchControls;
    #region Events
    public delegate void StartTouchEvent(Vector2 position, float time);
    public event StartTouchEvent OnStartTouch;

    public delegate void EndTouchEvent(Vector2 position, float time);
    public event EndTouchEvent OnEndTouch;
    #endregion


    private void Awake()
    {
        TouchControls = new TouchControls();
        mainCamera = Camera.main;
    }

    private void OnEnable()
    {
        TouchControls.Enable();
    }

    private void OnDisable()
    {
        TouchControls.Disable();
    }

    private void Start()
    {
        TouchControls.Touch.TouchPress.started += ctx => StartTouch(ctx);
        TouchControls.Touch.TouchPress.canceled += ctx => EndTouch(ctx);
    }

    public void StartTouch(InputAction.CallbackContext context)
    {
        //print("Touch Started " + TouchControls.Touch.TouchPosition.ReadValue<Vector2>());
        if (OnStartTouch != null) OnStartTouch(TouchControls.Touch.TouchPosition.ReadValue<Vector2>(), (float)context.startTime);
    }

    public void EndTouch(InputAction.CallbackContext context)
    {
        //print("Touch Started " + TouchControls.Touch.TouchPosition.ReadValue<Vector2>());
        if (OnEndTouch != null) OnEndTouch(TouchControls.Touch.TouchPosition.ReadValue<Vector2>(), (float)context.time);
    }

    public Vector2 PrimaryPosition()
    {
        return Utils.ScreenToWorld(mainCamera, TouchControls.Touch.TouchPosition.ReadValue<Vector2>());
    }
}
