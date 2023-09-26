using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleGenerator : MonoBehaviour
{
    public GameObject bubblePrefab;
    public int bubbleCount = 10;
    public float bubbleRadius = 2f;
    public float bubbleCooldown = 1f;
    
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        // Spawn a bubble every bubbleCooldown seconds
        if (Time.time % bubbleCooldown < Time.deltaTime) {
            SpawnBubble();
        }
        
    }
    public void SpawnBubble()
    {
        // Generate a random position within a sphere of radius bubbleRadius
        Vector3 randomPosition = Random.insideUnitSphere * bubbleRadius + transform.position;
        // Set the y position to 0
        randomPosition.y = 0;
        // Instantiate a bubble at the random position
        Instantiate(bubblePrefab, randomPosition, Quaternion.identity);
    }
    
}
