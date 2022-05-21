using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int score = 0;
    public int highScore = 0;
    
    [SerializeField] private TMP_Text text;

    [SerializeField] private SoundManager soundManager;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("Highscore");
    }

    void Update()
    {
        text.text = score.ToString();

        if (score >= highScore)
        {
            PlayerPrefs.SetInt("Highscore", score);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        soundManager.PlaySound("point");
    }
}
