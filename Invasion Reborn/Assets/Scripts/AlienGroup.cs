using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AlienGroup : MonoBehaviour
{
    public GameObject alienPrefab;  // Reference to the prefab to instantiate
    public int numberOfRows;        // Number of rows in the grid
    public int numberOfColumns;     // Number of columns in the grid
    public float horizontalSpacing = 1f; // Horizontal spacing between grid elements
    public float verticalSpacing = 1f;   // Vertical spacing between grid elements

    private List<GameObject> alienList = new List<GameObject>();

    public float moveSpeed = 0.5f; // Speed at which the sprite moves towards the origin
    
    private GameObject player;
    public int aliensRemaining;

    private Vector2 targetPosition = Vector2.zero;
    void Start()
    {
        aliensRemaining = numberOfRows * numberOfColumns;
        CreateAlienGrid();
        player = GameObject.Find("Player");

        Vector2 directionToTarget = targetPosition - (Vector2)transform.position;

        // Ensure the direction is normalized
        directionToTarget.Normalize();

        // Calculate the angle in radians
        float angle = Mathf.Atan2(directionToTarget.y, directionToTarget.x) * Mathf.Rad2Deg;

        // Adjust the angle by 90 degrees because we want "down" (negative y-axis) to face the target direction
        angle += 90f;

        // Set the rotation of the object
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    // Update is called once per frame
    void Update()
    {
        // The target position is the origin (0,0,0)
        Vector3 targetPosition = Vector3.zero;

        // Calculate the new position using Lerp for smooth movement
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        
        if (aliensRemaining <= 0)
        {
            
            Destroy(gameObject);
        }
    }

    void CreateAlienGrid()
    {
        // Clear previous aliens in the list
        foreach (GameObject alien in alienList)
        {
            if (alien != null)
            {
                Destroy(alien);
            }
        }
        alienList.Clear();

        // Get the starting position from the parent object
        Vector3 startPosition = transform.position;

        // Calculate the total width and height of the grid
        float totalWidth = (numberOfColumns - 1) * horizontalSpacing;
        float totalHeight = (numberOfRows - 1) * verticalSpacing;

        // Adjust the start position to center the grid
        Vector3 offset = new Vector3(totalWidth / 2, totalHeight / 2, 0);
        startPosition -= offset;

        // Instantiate the aliens and arrange them in a grid
        for (int row = 0; row < numberOfRows; row++)
        {
            for (int col = 0; col < numberOfColumns; col++)
            {
                // Calculate position relative to the parent
                Vector3 position = startPosition + new Vector3(col * horizontalSpacing, row * verticalSpacing, 0);
                GameObject newAlien = Instantiate(alienPrefab, position, Quaternion.identity);
                newAlien.transform.parent = transform; // Set the parent to keep the hierarchy clean
                alienList.Add(newAlien);
            }
        }
    }

}
