using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public int resources;
    public bool buildMode;
    private SpriteRenderer towerPlacement;

    public Sprite tower1;
    public Sprite tower2;
    public Sprite tower3;
    public Sprite tower4;
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
        if(towerSelected == 1)
        {
            buildMode = false;
            towerPlacement.sprite = null;
            towerSelected = 0;
        }
        else
        {
            towerSelected = 1;
            towerPlacement.sprite = tower1;
            buildMode = true;
        }
        
    }
    private void OnBuild2(InputValue inputValue)
    {
        towerSelected = 2;
        towerPlacement.sprite = tower2;
        buildMode = true;
    }
}
