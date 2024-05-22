using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UpdateResourcesUI : MonoBehaviour
{
    private int resources;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        resources = FindAnyObjectByType<GameBrain>().getResources();
        gameObject.GetComponent<TMP_Text>().SetText(resources.ToString());
    }
}
