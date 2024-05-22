using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.Android.Types;
using UnityEngine;

public class GameBrain : MonoBehaviour
{
    public int playerResources;
    public int playerHealth;
    public float enemiesRemaining;

    // Start is called before the first frame update
    void Start()
    {
        playerResources = 0;
        playerHealth = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getResources()
    {
        return playerResources;
    }
}
