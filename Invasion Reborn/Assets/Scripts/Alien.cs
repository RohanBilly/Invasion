using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Alien : MonoBehaviour
{
    private LevelController levelController;
    public AlienGroup alienGroup;
    public float moveSpeed = 0.3f; // Speed at which the sprite moves towards the origin
    private GameObject player;
    private int health;

    private bool destroyed;
    private void Awake()
    {
        destroyed = false;
        player = GameObject.Find("Player");
        alienGroup = GetComponentInParent<AlienGroup>();
        levelController = GameObject.Find("LevelController").GetComponent<LevelController>();
    }
    private void Start()
    {
        health = 10;
        alienGroup = GetComponentInParent<AlienGroup>();
    }

    void Update()
    {
        if(health < 0)
        {
            DestroyAlien();
            destroyed = true;
            player.GetComponent<Player>().resources += 10;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<DamageBlip>() != null) //Hits Earth
        {
            collision.GetComponent<DamageBlip>().TakeDamage();
            DestroyAlien();
            destroyed = true;
        }
        else if (collision.GetComponent<MoveProjectile>() != null)
        {
            Destroy(collision.gameObject);
            health -= 3;
           
        }else if (collision.GetComponent<AssultProjectile>() != null)
        {
            
            Destroy(collision.gameObject);
            health -= 1;
        }
    }

    private void DestroyAlien()
    {
        if (!destroyed)
        {
            
            alienGroup.aliensRemaining -= 1;
            levelController.aliensRemaining -= 1;
            Destroy(gameObject);
        }
        

        
    }
}

