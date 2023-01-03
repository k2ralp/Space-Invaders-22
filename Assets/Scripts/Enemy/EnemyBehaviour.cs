using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public AudioClip clip;

    public class Enemy
    {

        public int enemyCount;
        public Enemy(int amount)
        {
            enemyCount = amount;
        }

    }

    public Enemy enemyLeft = new Enemy(36);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the other object is the projectile by its tag
        if (collision.tag == "Laser")
        {
            ReduceEnemy();
            
            print("I'm Hit");
            print(enemyLeft.enemyCount + "Enemy Left");

            // Allows playing an audio clip even if the Alien is destroyed and removed from the scene
            AudioSource.PlayClipAtPoint(clip, Vector2.zero);

            // Destroy the Alien game object (the one this script is on)
            Destroy(gameObject);

            // Destroy the projectile game object
            Destroy(collision.gameObject);
        }
    }

    void ReduceEnemy()
    {
        enemyLeft.enemyCount = enemyLeft.enemyCount - 1;
    }
}
