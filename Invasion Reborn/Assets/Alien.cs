using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    public float moveSpeed = 0.5f; // Speed at which the sprite moves towards the origin
   

    private void Awake()
    {
        
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
        print(collision.name);
        if (collision.GetComponent<DamageBlip>() != null)
        {

            collision.GetComponent<DamageBlip>().TakeDamage();
            Destroy(gameObject);
        }
        else if (collision.GetComponent<MoveProjectile>() != null)
        {
            Destroy(gameObject);
            //Earth.GetComponent<GameBrain>().CollectResources(10);
        }
    }
}
