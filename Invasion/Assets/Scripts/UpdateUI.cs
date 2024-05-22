using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UpdateUI : MonoBehaviour
{
    public string value = "Resources";
    private int resources;
    private int health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(value == "Resources")
        {
            resources = FindAnyObjectByType<GameBrain>().getResources();
            gameObject.GetComponent<TMP_Text>().SetText(resources.ToString());
        }else if(value == "Health")
        {
            health = FindAnyObjectByType<GameBrain>().getHealth();
            gameObject.GetComponent<TMP_Text>().SetText(health.ToString());
        }
        
    }
}
