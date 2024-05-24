using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SwipeDetection : MonoBehaviour
{
    [SerializeField]
    private float minimumDistance = .2f;
    [SerializeField]
    private float maximumTime = 1f;

    [SerializeField, Range(0f,1f)]
    private float directionThreshold = .9f;

    private Camera mainCamera;
    private InputManager inputManager;

    private Vector2 startPosition;
    private float startTime;

    private Vector2 endPosition;
    private float endTime;

    public float swipeDistance;
    public float swipeTime;

    private void Awake()
    {
        inputManager = GameObject.Find("InputManager").GetComponent<InputManager>();
        mainCamera = Camera.main;
    }

    private void OnEnable()
    {
        inputManager.OnStartTouch += SwipeStart;
        inputManager.OnEndTouch += SwipeEnd;
    }
    private void OnDisable()
    {
        inputManager.OnStartTouch -= SwipeStart;
        inputManager.OnEndTouch -= SwipeEnd;
    }

    private void SwipeStart(Vector2 position, float time)
    {
       
        startPosition = position;
        startTime = time;
    }

    private void SwipeEnd(Vector2 position, float time)
    {
        
        endPosition = position;
        endTime = time;
        DetectSwipe();
    }

    private void DetectSwipe()
    {
        if (Vector3.Distance(startPosition, endPosition) >= minimumDistance &&
                (endTime-startTime) <= maximumTime){
            print("Swipe Detected");
            Debug.DrawLine(startPosition, endPosition, Color.red, 5f);

            Vector3 direction = endPosition - startPosition;
            Vector2 direction2D = new Vector2(direction.x, direction.y).normalized;

            swipeDistance = Vector3.Distance(startPosition, endPosition);
            

            swipeTime = startTime - endTime;
            Debug.Log(swipeDistance+ "   "+swipeTime);
            SwipeDirection(direction2D);
        }
    }
    
    private void SwipeDirection(Vector2 direction)
    {
        if (Vector2.Dot(Vector2.up, direction) > directionThreshold)
        {
            Debug.Log("Swipe UP");
        }
        else if (Vector2.Dot(Vector2.down, direction) > directionThreshold)
        {
            Debug.Log("Swipe down");
        }
        else if (Vector2.Dot(Vector2.left, direction) > directionThreshold)
        {
            mainCamera.GetComponent<Rotate>().RotationMomentum(swipeDistance*(1-swipeTime) * 0.5f);
            Debug.Log("Swipe left");            
        }
        else if (Vector2.Dot(Vector2.right, direction) > directionThreshold)
        {
            Debug.Log("Swipe UP right");
            mainCamera.GetComponent<Rotate>().RotationMomentum(swipeDistance * (1 - swipeTime) * 0.5f * -1);
        }
    }

}
