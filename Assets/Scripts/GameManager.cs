using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // Singleton instance
    public TextMeshProUGUI  playerLivesText; 
    public TextMeshProUGUI  scoreText;       
    public TextMeshProUGUI timerText; 
    private float time = 0f;  
    private bool isTimerRunning = true;
    private int playerLives = 3; // Initial lives
    private int score = 0;       // Initial score

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject); // Persist the GameManager across scenes
    }

    private void Start()
    {
        UpdateLivesUI(); 
        UpdateScoreUI();
    }

    public void ChangeLives(int amount)
    {
        playerLives += amount;
        playerLives = Mathf.Max(playerLives, 0); // Ensure lives don't go below zero
        UpdateLivesUI();

        if (playerLives <= 0)
        {
            RestartLevel();
        }
    }

    public void RestartLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        playerLives= 3; // Reset lives to 3 for the restart
        UpdateLivesUI();
    }
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreUI();
    }

    private void UpdateLivesUI()
    {
        playerLivesText.text = "Player: " + playerLives;
    }
    private void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score; 
    }
    void Update()
    {
        if (isTimerRunning)
        {
            time += Time.deltaTime;
            timerText.text = FormatTime(time);
        }
    }
    //===============timer functionality=======================
    public void StopTimer()
    {
        isTimerRunning = false;
    }

    private string FormatTime(float timeInSeconds)
    {
        int hours = Mathf.FloorToInt(timeInSeconds / 3600);
        int minutes = Mathf.FloorToInt((timeInSeconds % 3600) / 60);
        int seconds = Mathf.FloorToInt(timeInSeconds % 60);
        return $"{hours:00}:{minutes:00}:{seconds:00}";
    }
}
