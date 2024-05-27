using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Rotate : MonoBehaviour
{
    private Vector2 moveDirection;

    public Vector3 rotationPoint = Vector3.zero; // Point around which the camera will rotate
    public float rotationSpeed;
    public float accelerationSpeed;
    public float decellerationSpeed = 20f;
    public float maxRotationSpeed = 50f;
    void Update()
    {
        Dceleration();
        // Check for arrow key inputs
        if (moveDirection.x < 0)
        {
            if (rotationSpeed < maxRotationSpeed - accelerationSpeed)
            {
                rotationSpeed += accelerationSpeed;
            }
            else
            {
                rotationSpeed = maxRotationSpeed;
            }
            
        }
        else if (moveDirection.x > 0)
        {
            if (rotationSpeed > -maxRotationSpeed + accelerationSpeed)
            {
                rotationSpeed -= accelerationSpeed;
            }
            else
            {
                rotationSpeed = -maxRotationSpeed;
            }
        }
        RotateAroundPoint(rotationSpeed * Time.deltaTime);
           

    }
    

    private void Dceleration()
    {
        if (rotationSpeed > 0.11f)
        {
            rotationSpeed = rotationSpeed - (decellerationSpeed * Time.deltaTime);
        }
        else if (rotationSpeed < -0.11f)
        {
            rotationSpeed = rotationSpeed + (decellerationSpeed * Time.deltaTime);
        }
        else
        {
            rotationSpeed = 0;
        }
    }

    private void RotateAroundPoint(float angle)
    {
        // Rotate the camera around the specified point along the Z-axis
        transform.RotateAround(rotationPoint, Vector3.forward, angle);
    }

    private void OnMove(InputValue inputValue)
    {
        moveDirection = inputValue.Get<Vector2>();
    }
}

