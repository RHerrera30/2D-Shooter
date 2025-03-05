using TMPro;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private int totalScore = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore(int score)
    {
        totalScore += score;
        scoreText.text = "SCORE: " + totalScore.ToString();
    }
}
