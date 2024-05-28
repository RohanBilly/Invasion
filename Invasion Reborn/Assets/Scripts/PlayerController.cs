using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerControls playerControls;

    public GameObject ShipProjectile;


    void Start()
    {
        playerControls = new PlayerControls();
    }


    void Update()
    {

    }

    private void OnShoot()
    {
        Vector3 position = gameObject.transform.position;
        Quaternion rotation = gameObject.transform.rotation;
        Instantiate(ShipProjectile, position, rotation);
    }

}
