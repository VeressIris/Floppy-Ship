using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject scoreText;
    [SerializeField] private GameObject pauseScreen;
    [SerializeField] private GameObject audioManager;
    
    private bool gameRunning;

    void Start()
    {
        Time.timeScale = 1;
        gameRunning = true;

        gameOverScreen.SetActive(false);
        pauseScreen.SetActive(false);
    }

    void Update()
    {
        //pause game
        if (Input.GetKeyDown(KeyCode.Escape))
        {            
            if (Time.timeScale == 0 && gameRunning)
            {
                Time.timeScale = 1;
                pauseScreen.SetActive(false);
            }
            else if (Time.timeScale == 1 && gameRunning)
            {
                Time.timeScale = 0;
                pauseScreen.SetActive(true);
            }
        }
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        scoreText.SetActive(false);

        Time.timeScale = 0; //stops game
        audioManager.SetActive(false); //disables sound so you cant hear the jumping sound anymore if you press space while the death screen is on
        gameRunning = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
