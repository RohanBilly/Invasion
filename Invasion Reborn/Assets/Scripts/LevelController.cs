using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class LevelController : MonoBehaviour
{
    public bool inMenu;
    public bool levelStarted;

   
    public int levelNumber;
    public int minimumDistance;

    public int aliensRemaining;
    public GameObject alienGroup;
    // Start is called before the first frame update
    void Start()
    {
        inMenu = true;
        levelStarted = false;
        levelNumber = 0;
    }
    private void SpawnAlienGroup(Vector2 position, int rows, int columns, float horizontalSpacing, float verticalSpacing, float moveSpeed)
    {
        GameObject enemies = Instantiate(alienGroup, position, Quaternion.identity);
        enemies.GetComponent<AlienGroup>().numberOfRows = rows;
        enemies.GetComponent<AlienGroup>().numberOfColumns = columns;
        enemies.GetComponent<AlienGroup>().horizontalSpacing = horizontalSpacing;
        enemies.GetComponent<AlienGroup>().verticalSpacing = verticalSpacing;
        enemies.GetComponent<AlienGroup>().moveSpeed = moveSpeed;
        aliensRemaining += rows * columns;
        
    }

    private void Level1()
    {
        SpawnAlienGroup(RandomPosition(), 1, 1, 0.28f, 0.24f, 0.45f);
        minimumDistance += 3;
        SpawnAlienGroup(RandomPosition(), 3, 3, 0.28f, 0.24f, 0.45f);
        minimumDistance += 3;
        SpawnAlienGroup(RandomPosition(), 3, 3, 0.28f, 0.24f, 0.45f);

    }

    

    public void EnterPressed()
    {
        if (!levelStarted)
        {
            if (levelNumber == 0)
            {
                levelStarted = true;
                Level1();

            }
        }
    }

    private Vector2 RandomPosition()
    {

        float angle = Random.Range(0f, Mathf.PI * 2);
        float x = Mathf.Cos(angle) * minimumDistance;
        float y = Mathf.Sin(angle) * minimumDistance;
        Vector2 position = new Vector2(x, y);
        return position;
    }




    void Update()
    {
        
    }
}
