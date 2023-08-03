using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSystem : MonoBehaviour 
{
    public GameObject[] hearts; // hearts are in array, 1 heart is [0], 2 hearts is [1], etc...
    public int life;
    private bool dead;
   

    // Update runs through every single frame

    void Start()
    {
        life = hearts.Length;
    }

    void Update() 
    {
        if (dead == true) {
            Debug.Log("YOU PERISHED"); // Default death
            // Add death if for if toe-d kills u
        }
    }

    public void TakeDamage(int d) 
    {
        if ((life >= 1)) 
        {
            life -= d;
            Destroy(hearts[life].gameObject);
            if (life < 1) 
            {
                dead = true;
            }
        }  
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ow"))
        {
            TakeDamage(1);
        }
    }
}