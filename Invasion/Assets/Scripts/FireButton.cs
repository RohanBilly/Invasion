using UnityEngine;

public class PointOverlapChecker : MonoBehaviour
{
    private Collider2D collider2D;

    void Start()
    {
        // Get the Collider2D component attached to the GameObject
        collider2D = GetComponent<Collider2D>();

        if (collider2D == null)
        {
            Debug.LogError("No Collider2D component found on this GameObject.");
        }
    }

    // Method to check if the point is within the collider
    public bool IsPointInCollider(Vector2 point)
    {
        if (collider2D == null)
        {
            print("HERHEHE");
            return false;
        }

        return collider2D.OverlapPoint(point);
    }

    void Update()
    {
        // Example usage: Check if a specific point is within the collider
        Vector2 pointToCheck = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        
    }
}
