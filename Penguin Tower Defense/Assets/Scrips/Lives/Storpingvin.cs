using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storpingvin : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)              //Triggers when something collides with Storpingvin
    {
        if (collision.gameObject.tag == "Enemy")                    //If the gameobject that collides with the Storpingving has the "Enemy" tag
        {
            Debug.Log("has collide");
            PlayerStats.Lives--;
            Destroy(collision.gameObject);                          //Destroys the enemy
            if (PlayerStats.Lives <= 0)                             //If the player's lives are equal to or less than zero.
            {
                Debug.Log("DEAD");
                GameOver gameOver = FindObjectOfType<GameOver>();   //Finds the GameOver script in GameMaster
                gameOver.EndGame();                                 //Calls the "EndGame" function, ending the game
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
