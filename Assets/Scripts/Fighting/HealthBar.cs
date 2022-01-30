using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    private Image healthBar;
    public float currentHealth;
    private float maxHealth = 100f;
    private LevelManager levelManager;



    public void GameOver()
    {
        Application.Quit();
    }



    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth = levelManager.health;
        healthBar.fillAmount = currentHealth / maxHealth;
        if (currentHealth <= 0)
        {
            GameOver();
            SceneLoader.LoadGameOver();

        }

    }
}