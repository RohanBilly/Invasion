using UnityEngine;

public class MoveAwayFromOrigin : MonoBehaviour
{
    public GameObject origin;
    private Vector2 direction;
    public float speed = 5f;

    private void Awake()
    {
        origin = GameObject.Find("Origin");
    }

    private void Update()
    {
        direction = (transform.position - origin.transform.position).normalized;
        
        Vector2 movement = direction * speed * Time.deltaTime;
        transform.position = (Vector2)transform.position + movement;
    }
}