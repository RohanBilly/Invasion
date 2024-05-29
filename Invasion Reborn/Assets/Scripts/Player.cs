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

    private void OnBuild()
    {
        if (buildMode)
        {
            if (towerSelected == 1)
            {
                GameObject Tower1 = Instantiate(tower1, towerPlacement.gameObject.transform.position, towerPlacement.gameObject.transform.rotation);
            }
            buildMode = false;
            towerPlacement.sprite = null;
            towerSelected = 0;
        }
    }

}
