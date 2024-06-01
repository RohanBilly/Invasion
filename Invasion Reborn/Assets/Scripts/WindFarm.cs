using UnityEngine;

public class WindFarm : MonoBehaviour
{
    private GameObject player;

    public float resourceTimer;
    public float timeToWait = 5f;
    void Start()
    {
        player = GameObject.Find("Player");
        resourceTimer = 0;
    }

    void Update()
    {
        resourceTimer += Time.deltaTime;
        if (resourceTimer > timeToWait)
        {
            player.GetComponent<Player>().resources += 10;
            resourceTimer = 0;
        }
        
    }
}
