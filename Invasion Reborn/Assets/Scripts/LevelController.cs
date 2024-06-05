using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;


public class LevelController : MonoBehaviour
{
    private TextMeshProUGUI gameplayText;
    private Menus menu;
    private Player player;
    
    public bool inMenu;
    public bool gameOver;
    public bool levelStarted;
   
    public int levelNumber;
    public int minimumDistance;

    public int aliensRemaining;
    public GameObject alienGroup;

    public int maxEarthHealth = 10;
    public int earthHealth;

    void Start()
    {
        earthHealth = maxEarthHealth;
        gameOver = false;
        gameplayText = GameObject.Find("GameplayText").GetComponent<TextMeshProUGUI>();
        menu = GameObject.Find("MenuButtonsCanvas").GetComponent<Menus>();
        player = GameObject.Find("Player").GetComponent<Player>();
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
        SpawnAlienGroup(RandomPosition(), 1, 10, 0.28f, 0.24f, 0.45f);
        minimumDistance += 3;
        SpawnAlienGroup(RandomPosition(), 2, 2, 0.28f, 0.24f, 0.45f);
        SpawnAlienGroup(RandomPosition(), 1, 1, 0.28f, 0.24f, 0.45f);
        minimumDistance += 3;
        SpawnAlienGroup(RandomPosition(), 1, 3, 0.28f, 0.24f, 0.45f);
        SpawnAlienGroup(RandomPosition(), 2, 1, 0.28f, 0.24f, 0.45f);

    }

    

    public void EnterPressed()
    {
        if (!levelStarted && !gameOver)
        {
            if (levelNumber == 0)
            {
                levelStarted = true;
                Level1();

            }
        }else if (!levelStarted && gameOver)
        {
            ResetScene();
            inMenu = true;
            gameOver = false;
            gameplayText.text = "Press ENTER to start the round";
            menu.BackToMainMenu();
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
        if (!inMenu || !gameOver)
        {
            if (earthHealth <= 0)
            {
                levelStarted = false;
                gameOver = true;
                gameplayText.text = "GAME OVER";
            }
        }
    }

    private void ResetScene()
    {
        Alien[] aliens = FindObjectsOfType<Alien>(); // Find all objects with the Alien component
        foreach (Alien alien in aliens)
        {
            Destroy(alien.gameObject); // Destroy each object
        }
        AlienGroup[] alienGroups = FindObjectsOfType<AlienGroup>(); // Find all objects with the Alien component
        foreach (AlienGroup alien in alienGroups)
        {
            Destroy(alien.gameObject); // Destroy each object
        }
        earthHealth = maxEarthHealth;
        player.resources = 0;
        levelNumber = 0;
    }
}
