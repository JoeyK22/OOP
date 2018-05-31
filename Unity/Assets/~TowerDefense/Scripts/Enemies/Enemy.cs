using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace TowerDefense
{
    public class Enemy : MonoBehaviour
    {
        public float maxHealth = 100;
        [Header("UI")]
        public GameObject healthBarUI;
        public Vector2 healthBarOffset = new Vector2(0, 5f);

        private Slider healthSlider;
        private float health = 100f;

        void Start()
        {
            health = maxHealth;

        }

        Vector3 GetHealthBarPos()
        {
            Camera cam = Camera.main;
            // Converts world position to screen
            Vector3 position = cam.WorldToScreenPoint(transform.position);
            return position + (Vector3)healthBarOffset;
        }


        Vector3 GetHealthBarPos()
        {
            Camera cam = Camera.main;
            // Converts world position to screen
            Vector3 position = cam.WorldToScreenPoint(transform.position);
            //returns screen position + offset in pixels
            return position + (Vector3)healthBarOffset;
        }

        public void SpawnHealthBar(Transform parent)
        {
            GameObject clone = Instantiate(healthBarUI, GetHealthBarPos(), Quaternion.identity, parent);
            healthSlider = clone.GetComponent<Slider>();
        }

        /// <summary>
        /// Deals damage to the Droid
        /// </summary>
        /// <param name="damage">Damage to deal</param>
        public void DealDamage(float damage)
        {
            // Deal damage to droid
            health -= damage;
            // If there is no health
            if (health <= 0)
            {
                // Kill off GameObject
                Destroy(gameObject);
            }
        }
    }
}