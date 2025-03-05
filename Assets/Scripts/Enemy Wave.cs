using UnityEngine;

public class EnemyWave : MonoBehaviour
{
    public float speed = 3f;
    public float downwardMovement = 0.5f;
    public float upbound = 1.5f;
    public float downbound = -20f;
    private int direction = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
        Debug.Log("Moving down, changing direction");
        direction *= -1;
        transform.position += Vector3.down * downwardMovement;
    }
}
