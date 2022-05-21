using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuScore : MonoBehaviour
{
    [SerializeField] private GameObject palyer;

    [SerializeField] private Score scoreScript;

    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text highScoreText;

    void Start()
    {
        scoreScript = palyer.GetComponent<Score>();
    }

    void Update()
    {
        scoreText.text = "SCORE: " + scoreScript.score.ToString();
        highScoreText.text = "HIGH SCORE: " + scoreScript.highScore.ToString();
    }
}
