using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RenderOnGamplay : MonoBehaviour
{
    private LevelController levelController;

    void Start()
    {
        levelController = GameObject.Find("LevelController").GetComponent<LevelController>();    
    }

    void Update()
    {
        if (levelController.inMenu || levelController.levelStarted)
        {
            gameObject.GetComponent<Canvas>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<Canvas>().enabled = true;
        }
    }
}
