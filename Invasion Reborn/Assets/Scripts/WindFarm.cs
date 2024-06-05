using UnityEngine;

public class WindFarm : MonoBehaviour
{
    private GameObject player;
    private LevelController levelController;

    public float resourceTimer;
    private float timeToWait = 1.5f;
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
                player.GetComponent<Player>().resources += 1;
                resourceTimer = 0;
            }
        }
 
    }
}
