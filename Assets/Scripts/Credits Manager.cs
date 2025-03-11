using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class CreditsManager : MonoBehaviour
{
    public float delay = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(ReturntoMenu());
    }

    private IEnumerator ReturntoMenu()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("MenuScene");
    }
}
