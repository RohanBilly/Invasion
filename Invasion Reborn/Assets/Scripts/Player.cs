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


    private int towerSelected;

    private Rotate cameraRotation;

    void Start()
    {
        buildMode = false;
        resources = 0;
        towerPlacement = transform.Find("BuildArea").GetComponent<SpriteRenderer>();
        cameraRotation = Camera.main.GetComponent<Rotate>();
    }


    void Update()
    {

    }

    public void EnterBuildMode(Sprite towerImage)
    {

    }
    private void OnBuild1(InputValue inputValue)
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
    private void OnBuild2(InputValue inputValue)
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

    private void OnBuild3(InputValue inputValue)
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
    private void OnBuild4(InputValue inputValue)
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


    private void OnBuild()
    {
        if (buildMode)
        {
            if (towerSelected == 1)
            {
                GameObject Tower1 = Instantiate(tower1, towerPlacement.gameObject.transform.position, towerPlacement.gameObject.transform.rotation);
            }else if(towerSelected == 2)
            {
                GameObject Tower2 = Instantiate(tower2, towerPlacement.gameObject.transform.position, towerPlacement.gameObject.transform.rotation);
            }
            else if (towerSelected == 3)
            {
                GameObject Tower3 = Instantiate(tower3, towerPlacement.gameObject.transform.position, towerPlacement.gameObject.transform.rotation);
            }
            else if (towerSelected == 4)
            {
                GameObject Tower4 = Instantiate(tower4, towerPlacement.gameObject.transform.position, towerPlacement.gameObject.transform.rotation);
            }
            buildMode = false;
            towerPlacement.sprite = null;
            towerSelected = 0;
        }
    }

}
