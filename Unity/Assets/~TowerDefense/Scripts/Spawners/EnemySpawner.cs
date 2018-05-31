using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TowerDefense
{
    public class EnemySpawner : Spawner
    {
        public Transform path;
        [Header("UI")]
        public Transform healthBarParent;
        public float spawnRadius = 1f;


        private Transform start;
        private Transform end;


        void GetPath()
        {
            if (path != null)
            {
                start = path.FindChild("Start");
                end = path.FindChild("End");
            }
        }

        // Use this for initialization
        void Start()
        {
            GetPath();
        }

        void OnDrawGizmos()
        {
            GetPath();
            if (start != null)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawWireSphere(start.position, spawnRadius);
            }
        }

        public override void Spawn()
        {
            // Create an instance of an enemy
            GameObject clone = Instantiate(prefab, start.position, start.rotation);
            // Set clone under spawner as child
            clone.transform.SetParent(transform);
            // Set AI Agent's target to end
            AIAgent agent = clone.GetComponent<AIAgent>();
            agent.target = end;
            Debug.Log("moo");
            //spawn a healthbar
            Enemy enemy = clone.GetComponent<Enemy>();
            enemy.SpawnHealthBar(healthBarParent);
        }
    }
}