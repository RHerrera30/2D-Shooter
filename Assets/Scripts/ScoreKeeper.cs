using TMPro;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI startScoreText;
    public TextMeshProUGUI hgihScoreText;
    private int totalScore = 0;
    private int highScore = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        hgihScoreText.text = highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore(int score)
    {
        totalScore += score;
        if (totalScore > highScore)
        {
            highScore = totalScore;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }

        scoreText.text = "SCORE: " + totalScore;
        startScoreText.text = totalScore.ToString();
        hgihScoreText.text = highScore.ToString();
    }
}
