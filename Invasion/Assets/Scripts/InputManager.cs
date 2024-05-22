using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private TouchControls TouchControls;

    private void Awake()
    {
        TouchControls = new TouchControls();
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

    private void StartTouch(InputAction.CallbackContext context)
    {
        print("Touch Started " + TouchControls.Touch.TouchPosition.ReadValue<Vector2>());
    }

    private void EndTouch(InputAction.CallbackContext context)
    {

    }
}
