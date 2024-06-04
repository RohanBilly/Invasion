using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assult : MonoBehaviour
{
    private float timer = 0;
    public GameObject assaultProjectilePrefab; // Reference to the AssultProjectile prefab
    private LevelController levelController;


    void Start()
    {
        levelController = GameObject.Find("LevelController").GetComponent<LevelController>();
    }

    void Update()
    {
        if (levelController.aliensRemaining > 0 && FindClosestAlien() != null)
        {
            timer += Time.deltaTime;
            if (timer > 0.2f)
            {
                GameObject assultProjectile = Instantiate(assaultProjectilePrefab, transform.position, transform.rotation);
                if (assultProjectile.GetComponent<AssultProjectile>().closestAlien == null)
                {

                }
                timer = 0;
            }
        }
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
                print(angle);
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
            return null;

        }

    }
}

