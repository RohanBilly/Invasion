using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menus : MonoBehaviour
{
    public int menuSelection;
    private LevelController levelController;


    private GameObject mainMenu;
    private GameObject optionsMenu;

    private Image playButton;
    private Image optionsButton;
    private Image exitButton;

    private Image sfxSliderBg;
    private Image musicSliderBg;
    private Image returnButton;

    public Sprite playUnselected;
    public Sprite playSelected;

    public Sprite optionsUnselected;
    public Sprite optionsSelected;

    public Sprite exitUnselected;
    public Sprite exitSelected;

    public Sprite SfxSliderUnselected;
    public Sprite SfxSliderSelected;

    public Sprite musicSliderUnselected;
    public Sprite musicSliderSelected;

    public Sprite returnButtonUnselected;
    public Sprite returnButtonSelected;

    public RectTransform canvasRectTransform;

    private Slider musicVolumeSlider;
    private Slider sfxVolumeSlider;

    // Duration of the movement in seconds
    public float duration = 1.0f;

    // Distance to move in units
    public float distance = 20.0f;

    // Smoothing factor
    public float smoothing = 1.0f;
    void Start()
    {
        menuSelection = 0;

        levelController = GameObject.Find("LevelController").GetComponent<LevelController>();
        mainMenu = GameObject.Find("MainMenu");
        optionsMenu = GameObject.Find("OptionsMenu");
        playButton = GameObject.Find("PlayButton").GetComponent<Image>();
        optionsButton = GameObject.Find("OptionsButton").GetComponent<Image>();
        exitButton = GameObject.Find("ExitButton").GetComponent<Image>();

        sfxSliderBg = GameObject.Find("SfxBackground").GetComponent<Image>();
        musicSliderBg = GameObject.Find("MusicBackground").GetComponent<Image>();
        returnButton = GameObject.Find("ReturnButton").GetComponent<Image>();

        musicVolumeSlider = GameObject.Find("MusicSlider").GetComponent<Slider>();
        sfxVolumeSlider = GameObject.Find("SfxSlider").GetComponent<Slider>();

        canvasRectTransform = gameObject.GetComponent<RectTransform>();
    }

    public void UpdateMenu(int value)
    {
        if (menuSelection < 3)
        {
            menuSelection = menuSelection + value;
            if (menuSelection < 0)
            {
                menuSelection = 2;
            }
            else if (menuSelection > 2)
            {
                menuSelection = 0;
            }
        }
        else
        {
            menuSelection = menuSelection + value;
            if (menuSelection < 3)
            {
                menuSelection = 5;
            }else if(menuSelection > 5){
                menuSelection = 3;
            }
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
        else if (menuSelection == 3)
        {
            playButton.sprite = playUnselected;
            optionsButton.sprite = optionsUnselected;
            exitButton.sprite = exitUnselected;

            musicSliderBg.sprite = musicSliderSelected;
            sfxSliderBg.sprite = SfxSliderUnselected;
            returnButton.sprite = returnButtonUnselected;
        }
        else if (menuSelection == 4)
        {
            playButton.sprite = playUnselected;
            optionsButton.sprite = optionsUnselected;
            exitButton.sprite = exitUnselected;

            musicSliderBg.sprite = musicSliderUnselected;
            sfxSliderBg.sprite = SfxSliderSelected;
            returnButton.sprite = returnButtonUnselected;
        }
        else if (menuSelection == 5)
        {
            playButton.sprite = playUnselected;
            optionsButton.sprite = optionsUnselected;
            exitButton.sprite = exitUnselected;

            musicSliderBg.sprite = musicSliderUnselected;
            sfxSliderBg.sprite = SfxSliderUnselected;
            returnButton.sprite = returnButtonSelected;
        }
    }

    IEnumerator MoveObjectCoroutine(Transform objTransform, float moveDistance)
    {
        Vector3 startPosition = objTransform.position;
        Vector3 targetPosition = startPosition + new Vector3(moveDistance, 0, 0);

        float elapsedTime = 0;

        while (elapsedTime < duration)
        {
            objTransform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime / duration);
            elapsedTime += Time.deltaTime * smoothing;
            yield return null;
        }

        objTransform.position = targetPosition;
 
    }

    public void Select()
    {
       if (menuSelection == 0)
       {
            StartCoroutine(MoveObjectCoroutine(mainMenu.transform, distance));
            levelController.inMenu = false;
       }else if (menuSelection == 1)
       {
            StartCoroutine(MoveObjectCoroutine(mainMenu.transform, distance));
            StartCoroutine(MoveObjectCoroutine(optionsMenu.transform, distance));
            menuSelection = 3;

            musicSliderBg.sprite = musicSliderSelected;
            sfxSliderBg.sprite = SfxSliderUnselected;
            returnButton.sprite = returnButtonUnselected;
        }
        else if (menuSelection == 2)
        {
            //exit
        }else if (menuSelection == 3)
        {
            //Control music slider
        }
        else if (menuSelection == 4)
        {
            //Control sfx slider
        }
        else if (menuSelection == 5)
        {
          
            StartCoroutine(MoveObjectCoroutine(mainMenu.transform, -distance));
            StartCoroutine(MoveObjectCoroutine(optionsMenu.transform, -distance));
            menuSelection = 0;

            
            returnButton.sprite = returnButtonUnselected;

            playButton.sprite = playSelected;
            optionsButton.sprite = optionsUnselected;
            exitButton.sprite = exitUnselected;
        }
       
    }

    public void ChangeSliderValue(int value)
    {
        if (menuSelection == 3)
        {
            musicVolumeSlider.value += value * 0.1f;
        }else if (menuSelection == 4)
        {
            sfxVolumeSlider.value += value * 0.1f;
        }
    }

    public void BackToMainMenu()
    {
        StartCoroutine(MoveObjectCoroutine(mainMenu.transform, -distance));
        menuSelection = 0;


        returnButton.sprite = returnButtonUnselected;

        playButton.sprite = playSelected;
        optionsButton.sprite = optionsUnselected;
        exitButton.sprite = exitUnselected;
    }

    void Update()
    {
        
    }
}
