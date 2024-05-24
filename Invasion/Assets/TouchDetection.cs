using UnityEngine;

public class TouchDetection : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Vector3 touchPosition = mainCamera.ScreenToWorldPoint(touch.position);
                RaycastHit2D hit = Physics2D.Raycast(touchPosition, Vector2.zero);

                if (hit.collider != null && hit.collider.gameObject == gameObject)
                {
                    Debug.Log("GameObject Touched: " + gameObject.name);
                    OnTouch();
                }
            }
        }
    }

    void OnTouch()
    {
        // Add your custom logic here
        Debug.Log("Touched the GameObject: " + gameObject.name);
    }
}
