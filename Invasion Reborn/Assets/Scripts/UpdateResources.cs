using UnityEngine;
using TMPro;

public class UpdateResources : MonoBehaviour
{
    private TMP_Text tmpText;
    private GameObject player;

    void Start()
    {
        tmpText = GetComponent<TMP_Text>();
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        tmpText.text = player.GetComponent<Player>().resources.ToString();
    }
}
