using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpaceCheck : MonoBehaviour
{
    public bool spaceAvailable;
    public bool overUpgradeBay;
    private int towersColliding;
    void Start()
    {
        overUpgradeBay = false;
        towersColliding = 0;
        spaceAvailable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (towersColliding > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            spaceAvailable = false;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
            spaceAvailable = true;
        }
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Tower"))
        {
            if (other.GetComponent<UpgradeBay>() != null)
            {
                overUpgradeBay = true;
            }
            towersColliding++;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Tower"))
        {
            if (other.GetComponent<UpgradeBay>() != null)
            {
                overUpgradeBay = false;
            }
            towersColliding--;
        }
    }

}
