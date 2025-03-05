using UnityEngine;

public class Base : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Friendly fire!");
        Destroy(collision.gameObject);
        
        Destroy(gameObject);
    }
}
