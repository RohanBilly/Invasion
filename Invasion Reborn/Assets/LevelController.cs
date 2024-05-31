using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class LevelController : MonoBehaviour
{
    public bool inMenu;
    public int levelNumber;
    public int minimumDistance;

    public int aliensRemaining;
    public GameObject alienGroup;
    // Start is called before the first frame update
    void Start()
    {
        inMenu = true;
        
        levelNumber = 0;

        //Start Level
        // Generate a random angle in radians
        float angle = Random.Range(0f, Mathf.PI * 2);

        // Calculate the position on the circumference
        float x = Mathf.Cos(angle) * minimumDistance;
        float y = Mathf.Sin(angle) * minimumDistance;
        Vector2 position = new Vector2(x, y);

        SpawnAlienGroup(position, 3, 3, 0.28f, 0.24f, 0.45f);
       
    }
    private void SpawnAlienGroup(Vector2 position, int rows, int columns, float horizontalSpacing, float verticalSpacing, float moveSpeed)
    {
        GameObject enemies = Instantiate(alienGroup, position, Quaternion.identity);
        enemies.GetComponent<AlienGroup>().numberOfRows = rows;
        enemies.GetComponent<AlienGroup>().numberOfColumns = columns;
        enemies.GetComponent<AlienGroup>().horizontalSpacing = horizontalSpacing;
        enemies.GetComponent<AlienGroup>().verticalSpacing = verticalSpacing;
        enemies.GetComponent<AlienGroup>().moveSpeed = moveSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
