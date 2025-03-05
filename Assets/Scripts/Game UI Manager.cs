using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour
{
    public GameObject startCanvas;
    public GameObject gameOverCanvas;
    private bool gameStarted = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       startCanvas.SetActive(true);
       gameOverCanvas.SetActive(false);
       Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted && Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        startCanvas.SetActive(false);
        gameStarted = true;
        Time.timeScale = 1;
        //Need to call endgame when player dies
    }

    public void EndGame()
    {
        gameOverCanvas.SetActive(true);
        //Need to call restart
        Time.timeScale = 0;
    }

    //Not working
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Restart level
        Time.timeScale = 1;
    }
}
