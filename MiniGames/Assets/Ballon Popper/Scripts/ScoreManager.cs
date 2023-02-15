using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;

    private void Start() {
        UpdateScoreText();
    }

    public void IncreaseScore(int amount) {
        score += amount;
        UpdateScoreText();
    }

    private void UpdateScoreText() {
        scoreText.text = "SCORE: " + score;
    }
}
