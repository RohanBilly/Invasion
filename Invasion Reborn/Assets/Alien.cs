using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Alien : MonoBehaviour
{
    public float moveSpeed = 0.3f; // Speed at which the sprite moves towards the origin
    private GameObject player;

    private void Awake()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<DamageBlip>() != null)
        {
            collision.GetComponent<DamageBlip>().TakeDamage();
            Destroy(gameObject);
        }
        else if (collision.GetComponent<MoveProjectile>() != null)
        {
            Destroy(gameObject);
            player.GetComponent<PlayerStats>().resources += 10;
        }
    }
}
