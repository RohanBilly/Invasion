using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateHealthCount : MonoBehaviour
{
    private TMP_Text tmpText;
    private LevelController levelController;

    void Start()
    {
        tmpText = GetComponent<TMP_Text>();
        levelController = GameObject.Find("LevelController").GetComponent<LevelController>();
    }

    private void Update()
    {
        if (!levelController.gameOver)
        {
            tmpText.text = levelController.earthHealth.ToString();
        }
        
    }
}
