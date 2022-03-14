using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public void DealDamage()
    {
        int damageAmount;
        damageAmount = gameObject.GetComponent<EnemyModel>().Damage;                //Gets the Damage variable in EnemyModel
        if (PlayerStats.PlayerLives < damageAmount)                                     //Prevents getting negative health
        {
            PlayerStats.PlayerLives = 0;
            Debug.Log("0 lives");
        }
        else
        {
            PlayerStats.PlayerLives = PlayerStats.PlayerLives - damageAmount;         //Deals the amount of damage in EnemyModel.Damage
            Debug.Log("Damage is: " + damageAmount);
        }
        if (PlayerStats.PlayerLives == 0)
        {
            GameOver gameOver = FindObjectOfType<GameOver>();   //Finds the GameOver class in GameMaster
            gameOver.EndGame();                                 //Calls the "EndGame" function, ending the game
        }
        Debug.Log("Lives: " + PlayerStats.PlayerLives);
    }
}
