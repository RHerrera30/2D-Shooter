using UnityEngine;

public class EnemyWave : MonoBehaviour
{
    public float speed = 3f;
    public float speedIncrease = 0.1f;
    public float downwardMovement = 0.5f;
    public float upbound = 1.5f;
    public float downbound = -20f;
    private int direction = 1;
    private bool stopMovement;
    private int totalEnemies;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        totalEnemies = transform.childCount;
        Enemy.OnEnemyDied += EnemyOnOnEnemyDied;
    }

    private void EnemyOnOnEnemyDied(int points)
    {
        totalEnemies--;
        if (totalEnemies > 0)
        {
            speed += speedIncrease;
        }
        Debug.Log($"Enemy destroyed! New speed: {speed}");
    }

    // Update is called once per frame
    void Update()
    {
        if (stopMovement) return;
        
        transform.position += Vector3.right * (direction * speed * Time.deltaTime);

        if (transform.position.x >= upbound)
        {
            MoveDown();
        } else if (transform.position.x <= downbound)

        {
            MoveDown();
        }
    }

    void MoveDown()
    {
        // Debug.Log("Moving down, changing direction");
        direction *= -1;
        transform.position += Vector3.down * downwardMovement;
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Dome"))
        {
            stopMovement = true;
            Debug.Log("Enemy Wave Stopped!"); // Debug message
        }
        
    }
    public void StopMovement()
    {
        stopMovement = true;
        Debug.Log("Stopping movement");
    }
}
