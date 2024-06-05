using UnityEngine;
using TMPro;

public class UpdateResources : MonoBehaviour
{
    private TMP_Text tmpText;
    private GameObject player;
    private LevelController levelController;
    void Start()
    {
        tmpText = GetComponent<TMP_Text>();
        player = GameObject.Find("Player");
        levelController = GameObject.Find("LevelController").GetComponent<LevelController>();
    }

    private void Update()
    {
        if (!levelController.gameOver)
        {
            tmpText.text = player.GetComponent<Player>().resources.ToString();
        }
    }
}
