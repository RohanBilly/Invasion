using UnityEngine;
using UnityEngine.EventSystems;

public class TowerIcon : MonoBehaviour, IPointerClickHandler
{
    private GameObject player;

    public int towerType;
    private SpriteRenderer buildZoneImage;

    public Sprite towerImage;


    private void Awake()
    {
        player = GameObject.Find("Player");
        buildZoneImage = player.transform.Find("BuildArea").GetComponent<SpriteRenderer>();

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        player.GetComponent<Player>().EnterBuildMode(towerImage);


    }
}