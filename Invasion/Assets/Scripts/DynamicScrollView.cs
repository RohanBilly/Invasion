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

    private void Start()
    {
        foreach (Sprite tower in towers)
        {
            GameObject newTower = Instantiate(prefab, scrollViewContent);
            if (newTower.TryGetComponent<ScrollViewItem>(out ScrollViewItem item)){
                item.ChangeImage(tower);
            }
        }
    }
}
