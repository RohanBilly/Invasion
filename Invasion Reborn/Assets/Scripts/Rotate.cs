using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEditor.XR;
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
    public float slowAccelerationSpeed;
    public float slowDecellerationSpeed = 20f;
    public float slowMaxRotationSpeed = 50f;

    public bool slowMovement;

    private void Start()
    {
        slowMovement = false;
    }
    void Update()
    {
        Dceleration();
        // Check for arrow key inputs
        
        if (!slowMovement)
        {
            StandardMovement();
        }
        else
        {
            SlowMovement();
        }
        

        RotateAroundPoint(rotationSpeed * Time.deltaTime);
           

    }
    
    private void StandardMovement()
    {
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
    }

    private void SlowMovement()
    {
        if (moveDirection.x < 0)
        {
            if (rotationSpeed < slowMaxRotationSpeed - slowAccelerationSpeed)
            {
                rotationSpeed += slowAccelerationSpeed;
            }
            else
            {
                rotationSpeed = slowMaxRotationSpeed;
            }

        }
        else if (moveDirection.x > 0)
        {
            if (rotationSpeed > -slowMaxRotationSpeed + slowAccelerationSpeed)
            {
                rotationSpeed -= slowAccelerationSpeed;
            }
            else
            {
                rotationSpeed = -slowMaxRotationSpeed;
            }
        }
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

    public void OnSlow(InputValue inputValue)
    {
        // Check if the action is currently being held
        slowMovement = inputValue.isPressed;
    }
}
