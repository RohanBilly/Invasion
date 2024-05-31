using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private PlayerControls playerControls;
    private LevelController levelController;

    public GameObject ShipProjectile;

    private Menus menus;


    void Start()
    {
        playerControls = new PlayerControls();
        levelController = GameObject.Find("LevelController").GetComponent<LevelController>();

        menus = GameObject.Find("MenuButtonsCanvas").GetComponent<Menus>();
    }


    void Update()
    {

    }

    private void OnShoot()
    {
        if (!levelController.inMenu)
        {
           
            Vector3 position = gameObject.transform.position;
            Quaternion rotation = gameObject.transform.rotation;
            Instantiate(ShipProjectile, position, rotation);
        }
        
    }

    private void OnPause()
    {
        if (!levelController.inMenu)
        {
            print("PAUSE");

        }
    }

    private void OnEnter()
    {
        if (levelController.inMenu)
        {
            menus.MoveMenu();
            levelController.inMenu = false;
            print("Enter");

        }
    }

    private void OnUp()
    {
        if (levelController.inMenu)
        {
            menus.UpdateMenu(1);
        }
    }
    private void OnDown()
    {
        if (levelController.inMenu)
        {
            menus.UpdateMenu(-1);
        }
    }

   
    
}
