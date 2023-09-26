using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BubbleMovement : MonoBehaviour
{

    public float floatStrength = 2.0f; // Adjust this to control the strength of the floating effect.
    public float noiseSpeed = 1.0f; // Adjust this to control the speed of the noise.
    public float noiseScale = 1.0f; // Adjust this to control the scale of the noise.
    public int randomSeed = 12345; // Seed value for Perlin noise. Change as needed.
    
    // Range
    [Range(0, 10)]
    private float maxXAngle = 5f;
    public float randomDirection;

    private Vector3 initialPosition;
    private Rigidbody rb;

    void Start()
    {
        SetRandomColor();
        initialPosition = transform.position;
        rb = GetComponent<Rigidbody>();
        randomDirection = Random.Range(-1f, 1f) ;
        maxXAngle = Random.Range(0.1f, 5f);
        randomSeed = Random.Range(1, 100000);
        floatStrength = Random.Range(2f, 8f);
        noiseScale = Random.Range(0.1f, 2f);
        Random.InitState(randomSeed);

    }

    void Update()
    {
        // Calculate the Perlin noise value based on the object's position and time.
        float noiseValue = Mathf.PerlinNoise(Time.time * noiseSpeed, noiseScale);
        // Apply a force to make the object float.
        Vector3 floatForce = Vector3.up * noiseValue * floatStrength;
        // Get a random 1 or -1
        floatForce.x = floatForce.y/maxXAngle * randomDirection;
        rb.velocity = floatForce;
    }
    
    public void SetRandomColor()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }

}