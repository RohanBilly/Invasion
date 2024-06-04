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
        gameObject.GetComponent<SpriteRenderer>().sortingOrder = -1;
        closestAlien = FindClosestAlien();
        direction = (transform.position - closestAlien.transform.position).normalized;
        
        
        Destroy(gameObject, 2f);

        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = -direction * speed * Time.deltaTime;
        transform.position = (Vector2)transform.position + movement;
    }

    GameObject FindClosestAlien()
    {
        Vector2 facingDirection = transform.up;

        // Get all objects tagged as "Alien"
        GameObject[] aliens = GameObject.FindGameObjectsWithTag("Alien");
        GameObject closest = null;
        float minDistance = 5f;
        Vector3 currentPosition = transform.position;

        foreach (GameObject alien in aliens)
        {
            float distance = Vector3.Distance(alien.transform.position, currentPosition);
            if (distance < minDistance)
            {

                Vector2 directionToTarget = (alien.transform.position - transform.position).normalized;
                float angle = Vector2.Angle(facingDirection, directionToTarget);
                
                if (angle <= 90)
                {
                    closest = alien;
                    minDistance = distance;
                }


            }
        }
        if (closest != null)
        {
            return closest;
        }
        else
        {
            return gameObject;
            
        }
        
    }
}
