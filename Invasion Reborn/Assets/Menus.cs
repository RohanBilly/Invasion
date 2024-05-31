using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menus : MonoBehaviour
{
    private int menuSelection;


    private Image playButton;
    private Image optionsButton;
    private Image exitButton;

    public Sprite playUnselected;
    public Sprite playSelected;

    public Sprite optionsUnselected;
    public Sprite optionsSelected;

    public Sprite exitUnselected;
    public Sprite exitSelected;


    public RectTransform canvasRectTransform;

    // Duration of the movement in seconds
    public float duration = 1.0f;

    // Distance to move in units
    public float distance = 20.0f;

    // Smoothing factor
    public float smoothing = 1.0f;
    void Start()
    {
        menuSelection = 0;

        playButton = GameObject.Find("PlayButton").GetComponent<Image>();
        optionsButton = GameObject.Find("OptionsButton").GetComponent<Image>();
        exitButton = GameObject.Find("ExitButton").GetComponent<Image>();

        canvasRectTransform = gameObject.GetComponent<RectTransform>();
    }

    public void UpdateMenu(int value)
    {
        menuSelection = menuSelection + value;
        if (menuSelection < 0)
        {
            menuSelection = 2;
        }else if (menuSelection > 2)
        {
            menuSelection = 0;
        }

        if (menuSelection == 0)
        {
            playButton.sprite = playSelected;
            optionsButton.sprite = optionsUnselected;
            exitButton.sprite = exitUnselected;
        }
        else if(menuSelection == 1)
        {
            playButton.sprite = playUnselected;
            optionsButton.sprite = optionsSelected;
            exitButton.sprite = exitUnselected;
        }
        else if (menuSelection == 2)
        {
            playButton.sprite = playUnselected;
            optionsButton.sprite = optionsUnselected;
            exitButton.sprite = exitSelected;
        }
    }

    public void MoveMenu()
    {
        StartCoroutine(MoveObjectCoroutine(playButton.transform));
        StartCoroutine(MoveObjectCoroutine(optionsButton.transform));
        StartCoroutine(MoveObjectCoroutine(exitButton.transform));
    }


    IEnumerator MoveObjectCoroutine(Transform objTransform)
    {
        Vector3 startPosition = objTransform.position;
        Vector3 targetPosition = startPosition + new Vector3(distance, 0, 0);

        float elapsedTime = 0;

        while (elapsedTime < duration)
        {
            objTransform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime / duration);
            elapsedTime += Time.deltaTime * smoothing;
            yield return null;
        }

        objTransform.position = targetPosition;
    }

    void Update()
    {
        
    }
}
