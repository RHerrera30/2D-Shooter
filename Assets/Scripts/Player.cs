using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
  // Animator playerAnimator;
  [FormerlySerializedAs("bullet")] public GameObject bulletPrefab;
  
  public Transform shootingOffset;
  public float speed = 8f;
  public float bound = 7.5f;
  public GameUIManager gm;
  void Start()
  {
    Enemy.OnEnemyDied += EnemyOnOnEnemyDied;
    // playerAnimator = GetComponent<Animator>();
  }

  void OnDestroy()
  {
    Enemy.OnEnemyDied -= EnemyOnOnEnemyDied;
  }

  void EnemyOnOnEnemyDied(int points)
  {
    Debug.Log($"I know about dead enemy, points: {points}");
  }

  // Update is called once per frame
    void Update()
    {
      //Movement
      float moveInput = Input.GetAxis("Horizontal");
      Vector2 newPosition = transform.position + Vector3.right * (moveInput * speed * Time.deltaTime);
      newPosition.x = Mathf.Clamp(newPosition.x, -bound, bound);
      
      transform.position = newPosition;
      
      //Shoot
      if (Input.GetKeyDown(KeyCode.Space))
      {
        // playerAnimator.SetTrigger("Shoot Trigger");
        Shoot();
        //Destroy(shot, 3f);
      }
      void Shoot()
      {
        GameObject shot = Instantiate(bulletPrefab, shootingOffset.position, Quaternion.identity);
        Debug.Log("Bang!");
      }
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    { 
      Debug.Log("Player Ouch!");
      gm.EndGame();
      Destroy(collision.gameObject);
      Destroy(gameObject);
    }
}
