using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthText : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    public GameObject winText, gameOverText;
    private int health = 3;
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 30) Win();
    }

    public void TakeDamage(){
        health --;
        textMesh.text = health.ToString();
        if (health == 2) GetComponent<TextMeshProUGUI>().color = Color.yellow;
        if (health == 1) GetComponent<TextMeshProUGUI>().color = Color.red;
        
        if (health <= 0) GameOver();
       
    }

    private void GameOver(){
        gameOverText.SetActive(true);
        Time.timeScale = 0;
        Debug.Log("GameOver");
    }
    private void Win(){
        winText.SetActive(true);
        Time.timeScale = 0;
        Debug.Log("Win");
    }

}
