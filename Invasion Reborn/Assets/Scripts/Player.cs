using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int resources;
    public bool buildMode;
    private SpriteRenderer towerPlacement;
    private Rotate rotate;

    public Sprite tower1Image;
    public Sprite tower2Image;
    public Sprite tower3Image;
    public Sprite tower4Image;

    public GameObject tower1;
    public GameObject tower2;
    public GameObject tower3;
    public GameObject tower4;


    public GameObject ShipProjectile;

    private Transform earth;
    private LevelController levelController;

    private int towerSelected;

    private Rotate cameraRotation;

    private TowerSpaceCheck towerSpaceCheck;

    public int costOfFireRateUpgrade = 50;
    public int costOfSpeedUpgrade = 50;

    private float shootTimer;
    public float fireRate;


    void Start()
    {
        fireRate = 0.3f;
        shootTimer = 0;
        towerSpaceCheck = GameObject.Find("BuildArea").GetComponent<TowerSpaceCheck>();
        earth = GameObject.Find("Earth").transform;
        buildMode = false;
        resources = 0;
        towerPlacement = transform.Find("BuildArea").GetComponent<SpriteRenderer>();
        cameraRotation = Camera.main.GetComponent<Rotate>();
        levelController = GameObject.Find("LevelController").GetComponent<LevelController>();
        rotate = Camera.main.GetComponent<Rotate>();  
    }

    private void OnShoot()
    {
        if (!levelController.inMenu && !levelController.gameOver)
        {
            if (shootTimer > fireRate)
            {
                Vector3 position = gameObject.transform.position;
                Quaternion rotation = gameObject.transform.rotation;
                Instantiate(ShipProjectile, position, rotation);
                shootTimer = 0;
            }
            
        }

    }

    private void OnBuild1(InputValue inputValue)
    {
        if (!levelController.inMenu && !levelController.gameOver)
        {
            if (towerSpaceCheck.overUpgradeBay)
            {
                UpgradeFireRate();
            }else
            {
                ToggleTower(1);
            }
        }
    }
    private void OnBuild2(InputValue inputValue)
    {
        if (!levelController.inMenu && !levelController.gameOver)
        {
            if (towerSpaceCheck.overUpgradeBay)
            {
                UpgradeSpeed();  
            }
            else
            {
                ToggleTower(2);
            }
        }
    }

    private void OnBuild3(InputValue inputValue)
    {
        if (!levelController.inMenu && !levelController.gameOver)
        {
            ToggleTower(3);
        }
    }
    private void OnBuild4(InputValue inputValue)
    {
        if (!levelController.inMenu && !levelController.gameOver)
        {
            ToggleTower(4);
        }
    }


    

    private void OnBuild()
    {
        if (!levelController.inMenu && !levelController.gameOver)
        {
            if (buildMode && towerPlacement.gameObject.GetComponent<TowerSpaceCheck>().spaceAvailable)
            {
                if (towerSelected == 1)
                {
                    PlaceTower(tower1);

                }
                else if (towerSelected == 2)
                {
                    PlaceTower(tower2);
                }
                else if (towerSelected == 3)
                {
                    PlaceTower(tower3);
                }
                else if (towerSelected == 4)
                {
                    PlaceTower(tower4);
                }
            }
        }
    }

    private void PlaceTower(GameObject tower)
    {
        GameObject Tower1 = Instantiate(tower, towerPlacement.gameObject.transform.position, towerPlacement.gameObject.transform.rotation, earth);
        Tower1.transform.localScale = new Vector3(0.55f, 0.55f, 0);
        Tower1.GetComponent<SpriteRenderer>().sortingOrder = -2;
        buildMode = false;
        towerPlacement.sprite = null;
        towerSelected = 0;
    }

    private void ToggleTower(int towerNumber)
    {
        if (towerSelected == towerNumber)
        {
            buildMode = false;
            towerPlacement.sprite = null;
            towerSelected = 0;
        }
        else
        {
            towerSelected = towerNumber;
            towerPlacement.sprite = tower4Image;
            buildMode = true;
        }
    }

    private void UpgradeFireRate()
    {
        if (resources > 50)
        {
            fireRate -= 0.03f;
            resources -= 50;
        }
    }

    private void UpgradeSpeed()
    {
        if (resources > 50)
        {
            rotate.maxRotationSpeed += 5;
            resources -= 50;
        }
    }

    private void Update()
    {
        if (!levelController.inMenu)
        {
            shootTimer += Time.deltaTime;
        }
    }
}
