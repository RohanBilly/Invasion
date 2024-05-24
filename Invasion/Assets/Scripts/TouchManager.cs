using System.Drawing;
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

        Camera.main.ScreenToWorldPoint(touchPositionAction.ReadValue<Vector2>());
        //Debug.Log(position);
        string[] intersectingObjectNames = GetAllIntersectingObjectNames(position);

        if (intersectingObjectNames.Length > 0)
        {
            Debug.Log("GameObjects intersecting the point: " + position);
            foreach (string name in intersectingObjectNames)
            {
                Debug.Log("Intersecting GameObject: " + name);
            }
        }
        else
        {
            //Debug.Log("No GameObject is intersecting the point: " + position);
        }

    }


    public string[] GetAllIntersectingObjectNames(Vector2 point)
    {
        Collider2D[] colliders = Physics2D.OverlapPointAll(point);
        string[] intersectingObjectNames = new string[colliders.Length];

        for (int i = 0; i < colliders.Length; i++)
        {
            intersectingObjectNames[i] = colliders[i].gameObject.name;
        }

        return intersectingObjectNames;
    }

}
