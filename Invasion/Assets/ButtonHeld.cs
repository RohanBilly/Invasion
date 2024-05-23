using UnityEngine;

public class ButtonHeld : MonoBehaviour
{
    private Camera mainCamera;
    private bool isHeld = false;
    private Vector3 touchOffset;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Convert touch position to world position
            Vector3 touchPosWorld = mainCamera.ScreenToWorldPoint(touch.position);
            touchPosWorld.z = transform.position.z;

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    // Check if touch is over this object
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPosWorld))
                    {
                        isHeld = true;
                        touchOffset = transform.position - touchPosWorld;
                    }
                    break;

                case TouchPhase.Moved:
                    if (isHeld)
                    {
                        // Move the object along with the touch
                        transform.position = touchPosWorld + touchOffset;
                    }
                    break;

                case TouchPhase.Ended:
                    isHeld = false;
                    break;
            }
        }
    }
}
