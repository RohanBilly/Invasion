using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.Image;

public class AssultProjectile : MonoBehaviour
{
    public GameObject closestAlien;
    private Vector2 direction;
    public float speed = 40f;

    void Awake()
    {
        closestAlien = FindClosestAlien();
        direction = (transform.position - closestAlien.transform.position).normalized;
        Destroy(gameObject, 3f);

        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = -direction * speed * Time.deltaTime;
        transform.position = (Vector2)transform.position + movement;
    }

    GameObject FindClosestAlien()
    {
        // Get all objects tagged as "Alien"
        GameObject[] aliens = GameObject.FindGameObjectsWithTag("Alien");
        GameObject closest = null;
        float minDistance = Mathf.Infinity;
        Vector3 currentPosition = transform.position;

        foreach (GameObject alien in aliens)
        {
            float distance = Vector3.Distance(alien.transform.position, currentPosition);
            if (distance < minDistance)
            {
                closest = alien;
                minDistance = distance;
            }
        }

        return closest;
    }
}
