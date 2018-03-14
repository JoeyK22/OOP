using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Asteroids
{
    public class Shooting : MonoBehaviour
    {
        public GameObject bulletPrefab;
        public float bulletSpeed = 5f;
        public Transform spawnPoint;

        public void Fire(Vector3 direction)
        {
            GameObject clone = Instantiate(bulletPrefab);
            // Set position of clone to spawn point
            clone.transform.position = spawnPoint.position;
            float angle = Mathf.Atan2(direction.y, direction.x);
            float degrees = angle * Mathf.Rad2Deg;
            Rigidbody2D rigid = clone.GetComponent<Rigidbody2D>();
            rigid.rotation = degrees;


            rigid.AddForce(direction * bulletSpeed, ForceMode2D.Impulse);

        }
    }
}