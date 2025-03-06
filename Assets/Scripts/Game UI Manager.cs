using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour
{
    public GameObject startCanvas;
    public GameObject gameOverCanvas;
    private bool gameStarted = false;
    private bool gameOver = false;
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
        if (!gameStarted && Input.GetKeyDown(KeyCode.F))
        {
            StartGame();
        }
        
        if (gameOver && Input.GetKeyDown(KeyCode.F))
        { 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Restart level
            Time.timeScale = 1;
        }
    }

    public void StartGame()
    {
        startCanvas.SetActive(false);
        gameStarted = true;
        Time.timeScale = 1;
    }

    public void EndGame()
    {
        startCanvas.SetActive(true);
        gameOver = true;
        Time.timeScale = 0;
        //Need to call restart
        
    }

    //Not working
    // public void RestartGame()
    // {
    //     
    // }
}
