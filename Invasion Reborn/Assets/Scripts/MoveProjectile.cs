using UnityEngine;

public class MoveProjectile : MonoBehaviour
{
    public GameObject origin;
    private Vector2 direction;
    public float speed = 50f;

    private void Awake()
    {
        origin = GameObject.Find("Origin");
        Destroy(gameObject, 3f);
    }

    private void Update()
    {
        direction = (transform.position - origin.transform.position).normalized;

        Vector2 movement = direction * speed * Time.deltaTime;
        transform.position = (Vector2)transform.position + movement;
    }

}

