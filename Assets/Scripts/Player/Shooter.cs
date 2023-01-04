using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    public GameObject projectile2Prefab;
    public int fireLeft = 3;
    public Text fireText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Shoot();
        }

        if (Input.GetButtonDown("Fire1"))
        {
            ShootFireBall();
        }
    }

    void Shoot()
    {
        // Create a clone of the projectile's prefab during gameplay
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }

    void ShootFireBall()
    {
        // Create a clone of the fire projectile's prefab during gameplay
        if (fireLeft > 0)
        {
            Instantiate(projectile2Prefab, transform.position, Quaternion.identity);
            fireLeft--;
            TextChange();
        }

        else
        {
            print("No fireball left!");
        }
    }

    void TextChange()
    {
        fireText.text = "Press [Ctrl] " + fireLeft + " fireball left.";
    }
}
