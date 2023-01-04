using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public AudioClip clip;
    bool isDead = false;

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
        if (collision.tag == "Laser" && isDead==false)
        {
            isDead = true;

            Debug.Log("I'm Hit");
            CanvasController.Instance.reduceEnemyCount();

            if (CanvasController.Instance.enemyCount < 1)
            {
                CanvasController.Instance.RestartPanel.SetActive(true);
            }
            Debug.Log(CanvasController.Instance.enemyCount + "left");

            // Allows playing an audio clip even if the Alien is destroyed and removed from the scene
            AudioSource.PlayClipAtPoint(clip, Vector2.zero);

            // Destroy the Alien game object (the one this script is on)
            Destroy(gameObject);

            // Destroy the projectile game object
            Destroy(collision.gameObject);


        }

    }

}
