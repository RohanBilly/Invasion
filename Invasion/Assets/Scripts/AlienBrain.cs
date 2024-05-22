using UnityEngine;

public class AlienBrain : MonoBehaviour
{
    public float moveSpeed = 0.5f; // Speed at which the sprite moves towards the origin
    private GameObject Earth;

    private void Awake()
    {
       Earth = FindObjectOfType<GameBrain>().gameObject;
}

    void Update()
    {
        // The target position is the origin (0,0,0)
        Vector3 targetPosition = Vector3.zero;

        // Calculate the new position using Lerp for smooth movement
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<GameBrain>() != null)
        {
            Earth.GetComponent<GameBrain>().Damage();
            Earth.GetComponent<GameBrain>().playerHealth -= 1;
            Destroy(gameObject);
        }
    }
}
