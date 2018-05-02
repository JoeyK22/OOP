using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minesweeper2D
{

    [RequireComponent(typeof(SpriteRenderer))]

    public class Tile : MonoBehaviour
    {

        public int x, y; //sets a location along the array
        public bool isMine;
        public bool isRevealed;

        [Header("References")]
        public Sprite[] emptySprites;   //list of empty sprites
        public Sprite[] mineSprites;    //mine sprites

        private SpriteRenderer rend;    //referencing the sprite renderer

        void Awake()
        {
            rend = GetComponent<SpriteRenderer>(); 
        }

        
        void Start()
        {
            isMine = Random.value < 0.05f;
        }

        public void Reveal(int adjacentMines, int mineState = 0)
        {
            isRevealed = true;

            if (isMine)
            {
                rend.sprite = mineSprites[mineState];
            }

            else
            {
                rend.sprite = emptySprites[adjacentMines];
            }
        }
    }
}