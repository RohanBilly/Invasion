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

    private void Awake()
    {
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
        if(health <= 0)
        {
            DestroyAlien();
            player.GetComponent<Player>().resources += 10;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Earth") //Hits Earth
        {
            collision.GetComponent<DamageBlip>().TakeDamage();
            levelController.earthHealth -= 1;
            DestroyAlien();
        }
        else if (collision.GetComponent<MoveProjectile>() != null)
        {
            Destroy(collision.gameObject);
            health -= 5;
           
        }else if (collision.GetComponent<AssultProjectile>() != null)
        {
            
            Destroy(collision.gameObject);
            health -= 2;
        }
    }

    private void DestroyAlien()
    {
        alienGroup.aliensRemaining -= 1;
        if (levelController.aliensRemaining < 1)
        {
            levelController.aliensRemaining = 0;
        }
        else
        {
            levelController.aliensRemaining -= 1;
        }
        Destroy(gameObject);
    }
}

