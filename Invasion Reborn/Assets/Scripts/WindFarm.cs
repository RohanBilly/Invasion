using UnityEngine;

public class WindFarm : MonoBehaviour
{
    private GameObject player;
    private LevelController levelController;

    public float resourceTimer;
    public float timeToWait = 5f;
    void Start()
    {
        levelController = GameObject.Find("LevelController").GetComponent<LevelController>();
        player = GameObject.Find("Player");
        resourceTimer = 0;
    }

    void Update()
    {
        if (levelController.levelStarted)
        {
            resourceTimer += Time.deltaTime;
            if (resourceTimer > timeToWait)
            {
                player.GetComponent<Player>().resources += 10;
                resourceTimer = 0;
            }
        }
 
    }
}
