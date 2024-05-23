using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject prefab; // The prefab to instantiate
    

    public void Shoot()
    {
        // Get the position and rotation of the reference object
        Vector3 position = gameObject.transform.position;
        Quaternion rotation = gameObject.transform.rotation;

        // Instantiate the prefab at the position and rotation of the reference object
        Instantiate(prefab, position, rotation);
    }
}
