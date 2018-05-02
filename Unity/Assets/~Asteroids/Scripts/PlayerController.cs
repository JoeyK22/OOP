using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Asteroids
{
    public class PlayerController : MonoBehaviour
    {

        public Moving movement;

        public Shooting shoot;


        #region Unity Functions
        // Use this for initialization
        private void Start()
        {
            movement = GetComponent<Moving>();
        }

        // Update is called once per frame
        void Update()
        {
            Movement();
            Shoot();
        }
        #endregion

        #region Custom Functions
        void Shoot()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                shoot.Fire(transform.up);
            }
        }
        void Movement()
        {
            float inputV = Input.GetAxis("Vertical");
            // -1   == S || DownArrow
            //  0   == Not Pressed
            //  1   == W || UpArrow

            float inputH = Input.GetAxis("Horizontal");
            // -1   == A || LeftArrow
            //  0   == Not Pressed
            //  1   == D || RightArrow


            if (inputV > 0)
            {
                movement.Accelerate(transform.up);
            }

            if (inputH < 0)
            {
                movement.RotateLeft();
            }

            if (inputH > 0)
            {
                movement.RotateRight();
            }
            if (Input.GetKey(KeyCode.S))
            {
                movement.Stop();
            }
        }
        #endregion
    }
}