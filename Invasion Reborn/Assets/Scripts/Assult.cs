using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assult : MonoBehaviour
{
    private float timer = 0;
    public GameObject assaultProjectilePrefab; // Reference to the AssultProjectile prefab



    void Start()
    {
        
    }


    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.2f)
        {
            GameObject assultProjectile = Instantiate(assaultProjectilePrefab, transform.position, Quaternion.identity);
            timer = 0;
        } 
    }

    
    void ShootAtAlien()
    {
  
        
        
    }
}

