using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UpgradeBay : MonoBehaviour
{
    private TowerSpaceCheck towerSpaceCheck;

    private void Start()
    {
        towerSpaceCheck = GameObject.Find("BuildArea").GetComponent<TowerSpaceCheck>();
    }

    private void Update()
    {
        if (towerSpaceCheck.overUpgradeBay)
        {

        }
    }
}
