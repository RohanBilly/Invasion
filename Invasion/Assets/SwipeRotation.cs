using UnityEngine;

public class SwipeRotation : MonoBehaviour
{
    public float rotationSpeed = 1f; // Speed of rotation

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                float swipeDelta = touch.deltaPosition.x;

                // Rotate the camera around (0,0) based on swipe direction
                transform.RotateAround(Vector2.zero, Vector3.forward, -swipeDelta * rotationSpeed * Time.deltaTime);
            }
        }
    }
}
