using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private Transform scrollViewContent;

    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    private List<Sprite> towers;

    private int towerCount;


    private void Start()
    {
        towerCount = 0;
        foreach (Sprite tower in towers)
        {
            GameObject newTower = Instantiate(prefab, scrollViewContent);
            newTower.name = "Tower"+towerCount.ToString();
            towerCount += 1;
            if (newTower.TryGetComponent<ScrollViewItem>(out ScrollViewItem item)){
                item.ChangeImage(tower);
            }
        }
    }
}
