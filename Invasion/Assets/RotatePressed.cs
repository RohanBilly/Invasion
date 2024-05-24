using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotatePressed : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private GameObject mainCamera;

    private bool isHeld = false;
    private float holdTime = 0.5f; // Adjust this value as needed
    private float holdTimer = 0f;

    public bool direction;

    private void Awake()
    {
        mainCamera = GameObject.Find("Main Camera");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isHeld = true;
        if (direction)
        {
            mainCamera.GetComponent<Rotate>().leftPressed = true;
        }
        else
        {
            mainCamera.GetComponent<Rotate>().rightPressed = true;
        }
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isHeld = false;
        mainCamera.GetComponent<Rotate>().leftPressed = false;
        mainCamera.GetComponent<Rotate>().rightPressed = false;
    }

    void Update()
    {
        if (isHeld)
        {
            holdTimer += Time.deltaTime;
            if (holdTimer >= holdTime)
            {
                Debug.Log("Button Held");
                // Add your logic for when the button is held here
            }
        }
    }
}