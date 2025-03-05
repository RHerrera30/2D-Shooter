using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shootingOffset;
    public float minFireRate = 5f;
    public float maxFireRate = 10f;
    public delegate void EnemyDied(int points);
    public static event EnemyDied OnEnemyDied;
    public int enemyType;
    public ScoreKeeper scoreKeeper;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Shoot", Random.Range(minFireRate, maxFireRate));
    }
    void OnCollisionEnter2D(Collision2D collision)
    { 
        Debug.Log("Ouch!");
        Destroy(collision.gameObject);

        if (enemyType == 1)
        {
            scoreKeeper.addScore(10);
        } else if (enemyType == 2)
        {
            scoreKeeper.addScore(20);
        } else if (enemyType == 3)
        {
            scoreKeeper.addScore(30);
        } else if (enemyType == 4)
        {
            scoreKeeper.addScore(40);
        } else if (enemyType == 5)
        {
            scoreKeeper.addScore(50);
        }

        OnEnemyDied?.Invoke(1);
        Destroy(gameObject);
    }
    void Shoot()
    {
        GameObject shot = Instantiate(bulletPrefab, shootingOffset.position, Quaternion.identity);
        Debug.Log("Enemy Bang!");
        Invoke("Shoot", Random.Range(minFireRate, maxFireRate));
    }

    // void OnTriggerEnter2D(Collider2D collision)
    // {
    //     if (collision.gameObject.CompareTag("Player"))
    //     {
    //         wave.StopMovement();
    //     }
    // }
}
