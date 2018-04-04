using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Asteroids
{
    public class Shooting : MonoBehaviour
    {
        public GameObject bulletPrefab;
        public Transform[] spawnPoints;
        public float bulletSpeed = 5f;

        // Spawn a new bullet and fires in 'direction' when called
        public void Fire(Vector3 direction)
        {
            // Loop through spawn points
            for (int i = 0; i < spawnPoints.Length; i++)
            {
                // Spawn a bullet for each
                Spawn(direction, spawnPoints[i].position);
            }
        }

        void Spawn(Vector3 direction, Vector3 point)
        {
            // Make an instance of bullet prefab
            GameObject clone = Instantiate(bulletPrefab);
            // Set position of clone to spawn point
            clone.transform.position = point;
            float angle = Mathf.Atan2(direction.y, direction.x);
            float degrees = angle * Mathf.Rad2Deg;
            // Get rigidbody from bullet clone
            Rigidbody2D rigid = clone.GetComponent<Rigidbody2D>();
            rigid.rotation = degrees;
            // Add force in the direction
            rigid.AddForce(direction * bulletSpeed, ForceMode2D.Impulse);
        }
    }
}