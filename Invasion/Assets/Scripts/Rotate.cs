using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 rotationPoint = Vector3.zero; // Point around which the camera will rotate
    public float rotationSpeed = 50f;            // Speed of rotation

    public bool leftPressed;
    public bool rightPressed;

    public float decellerationSpeed = 0.1f;

    private void Awake()
    {
        leftPressed = false;
        rightPressed = false;
    }

    void Update()
    {
        // Check for arrow key inputs
        /*if (Input.GetKey(KeyCode.LeftArrow) || leftPressed == true)
        {
            RotateAroundPoint(rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow) || rightPressed == true)
        {
            RotateAroundPoint(-rotationSpeed * Time.deltaTime);
        }*/
        RotateAroundPoint(rotationSpeed * Time.deltaTime);
        if (rotationSpeed> 0.11f)
        {
            rotationSpeed = rotationSpeed - decellerationSpeed;
        }else if (rotationSpeed < -0.11f)
        {
            rotationSpeed = rotationSpeed + decellerationSpeed;
        }
        else
        {
            rotationSpeed = 0;
        }
        
    }

    void RotateAroundPoint(float angle)
    {
        // Rotate the camera around the specified point along the Z-axis
        transform.RotateAround(rotationPoint, Vector3.forward, angle);
    }

    public void RotationMomentum(float force)
    {
        rotationSpeed += force;
    }
}
