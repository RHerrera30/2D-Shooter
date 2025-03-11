using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPress : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    
    public void LoadGameScene()
    {
        StartCoroutine(_LoadGameScene());

        IEnumerator _LoadGameScene()
        {
           // SceneManager.LoadScene("DemoScene");
           AsyncOperation loadOp = SceneManager.LoadSceneAsync("DemoScene");
           while (!loadOp!.isDone) yield return null;
           
            GameObject player = GameObject.Find("Player");
            Debug.Log(player.name);
        }
        
    }

    public void LoadCreditsScene()
    {
        SceneManager.LoadScene("CreditsScene");
    }
}
