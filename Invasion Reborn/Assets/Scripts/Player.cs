using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public int resources;
    public bool buildMode;
    private SpriteRenderer towerPlacement;

    public Sprite tower1Image;
    public Sprite tower2Image;
    public Sprite tower3Image;
    public Sprite tower4Image;

    public GameObject tower1;
    public GameObject tower2;
    public GameObject tower3;
    public GameObject tower4;

    public Transform earth;
    private LevelController levelController;

    private int towerSelected;

    private Rotate cameraRotation;

    void Start()
    {
        earth = GameObject.Find("Earth").transform;
        buildMode = false;
        resources = 0;
        towerPlacement = transform.Find("BuildArea").GetComponent<SpriteRenderer>();
        cameraRotation = Camera.main.GetComponent<Rotate>();
        levelController = GameObject.Find("LevelController").GetComponent<LevelController>();
    }



    private void OnBuild1(InputValue inputValue)
    {
        if (!levelController.inMenu)
        {
            if (towerSelected == 1)
            {
                buildMode = false;
                towerPlacement.sprite = null;
                towerSelected = 0;
            }
            else
            {
                towerSelected = 1;
                towerPlacement.sprite = tower1Image;
                buildMode = true;
            }
        }
    }
    private void OnBuild2(InputValue inputValue)
    {
        if (!levelController.inMenu)
        {
            if (towerSelected == 2)
            {
                buildMode = false;
                towerPlacement.sprite = null;
                towerSelected = 0;
            }
            else
            {
                towerSelected = 2;
                towerPlacement.sprite = tower2Image;
                buildMode = true;
            }
        }
    }

    private void OnBuild3(InputValue inputValue)
    {
        if (!levelController.inMenu)
        {
            if (towerSelected == 3)
            {
                buildMode = false;
                towerPlacement.sprite = null;
                towerSelected = 0;
            }
            else
            {
                towerSelected = 3;
                towerPlacement.sprite = tower3Image;
                buildMode = true;
            }
        }
    }
    private void OnBuild4(InputValue inputValue)
    {
        if (!levelController.inMenu)
        {
            if (towerSelected == 4)
            {
                buildMode = false;
                towerPlacement.sprite = null;
                towerSelected = 0;
            }
            else
            {
                towerSelected = 4;
                towerPlacement.sprite = tower4Image;
                buildMode = true;
            }
        }
    }


    private void OnBuild()
    {
        if (!levelController.inMenu)
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
}
