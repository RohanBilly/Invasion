using UnityEngine;
using UnityEngine.InputSystem;

public class TouchManager : MonoBehaviour
{
    private PlayerInput playerInput;

    private InputAction touchPositionAction;
    private InputAction touchPressAction;

    private void Awake()
    {
       playerInput = GetComponent<PlayerInput>();
       touchPressAction = playerInput.actions.FindAction("TouchPress");
       touchPositionAction = playerInput.actions.FindAction("TouchPosition");
    }

    private void OnEnable()
    {
        touchPressAction.performed += TouchPressed;
    }

    private void OnDisable()
    {
        touchPressAction.performed -= TouchPressed;
    }


    private void TouchPressed(InputAction.CallbackContext context)
    {
        Vector2 position = touchPositionAction.ReadValue<Vector2>();
        Debug.Log(position);
        Camera.main.ScreenToWorldPoint(touchPositionAction.ReadValue<Vector2>());
        Debug.Log(position);
        
    }


}
