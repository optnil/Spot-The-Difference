using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoringManager : MonoBehaviour
{
    public int maxDifferences; // Total number of differences in the stage.
    public int startingLives; // Initial number of lives.
    public Text scoreText; // Reference to a UI Text component for displaying the score.
    public Text livesText; // Reference to a UI Text component for displaying the remaining lives.
    public GameEndManager gameEnd;

    public Image[] life_hearts = new Image[3];
    public GameObject[] score_fills = new GameObject[5];

    private int differencesFound = 0; // Differences found in the current stage.
    private int lives; // Current number of lives.
    private int score = 0; // Current score.


    private void Start()
    {
        startingLives = 3;
        maxDifferences = 5;

        lives = startingLives;

        //UpdateUI();
    }

    // Call this method when a difference is found.
    public void DifferenceFound()
    {
        differencesFound++;

        // Update the score when a difference is found.
        score ++; // You can adjust the score as needed.
        UpdateUI();

        if (differencesFound >= maxDifferences)
        {
            // Player has found all the differences in the stage.
            Debug.Log("Stage Completed!");
            Invoke("GameEndAnimation",1);
        }
    }

    public void GameEndAnimation()
    {
        gameEnd.ShowPopup(maxDifferences);
    }

    // Call this method when a life is lost.
    public void LoseLife()
    {
        if (lives > 0)
        {
            lives--;
            UpdateUI();
        }
        

        if (lives <= 0)
        {
            // Player has run out of lives.
            gameEnd.Game_lost_popup();
            Debug.Log("Game Over - No more lives!");
        }
        else
        {
            // Restart the stage.
            //differencesFound = 0;
        }

    }

    // Helper method to update the UI.
    private void UpdateUI()
    {
        scoreText.text = "Score: " + score;
        livesText.text = "Lives: " + lives;
        if(score > 0 && score <= maxDifferences)
        {
            Debug.Log("reaching score bar activation of  " + score_fills[score-1].name);
            score_fills[score - 1].SetActive(true);
        }
        if (lives >= 0 && lives < 3)
        {
            life_hearts[lives].enabled = false;
        }
    }
}
