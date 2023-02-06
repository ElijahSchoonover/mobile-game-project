using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject prefab;
    public float bulletSpeed = 10.0f;
    public float bulletLifetime = 2.0f;
    public GameObject player;
    public float close = 5.0f;
    public float shootDelay = 1.0f;
    float timer = 0.0f;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Vector3 shootDirection = player.transform.position - transform.position;
        float shootDist = shootDirection.magnitude;
        shootDirection.Normalize();

        // Checks if player is close enough to enemy, then sets the velocity of the enemy
        if (shootDist <= close)
        {
            if (timer >= shootDelay)
            {
                GameObject bulletSpawn = Instantiate(prefab, transform.position, Quaternion.identity);
                bulletSpawn.GetComponent<Rigidbody2D>().velocity = shootDirection * bulletSpeed;
                Destroy(bulletSpawn, bulletLifetime);
                timer = 0;
            }
        }
    }
}
