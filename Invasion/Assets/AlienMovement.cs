using UnityEngine;

public class MoveTowardsOrigin : MonoBehaviour
{
    public float moveSpeed = 1f; // Speed at which the sprite moves towards the origin

    void Update()
    {
        // The target position is the origin (0,0,0)
        Vector3 targetPosition = Vector3.zero;

        // Calculate the new position using Lerp for smooth movement
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }
}
