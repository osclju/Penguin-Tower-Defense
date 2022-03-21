using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public void DealDamage()
    {
        int damageAmount;
        damageAmount = gameObject.GetComponent<EnemyModel>().enemyStats.Dmg;                //Gets the Damage variable in EnemyModel
        if (PlayerStats.PlayerLives < damageAmount)                                     //Prevents getting negative health
        {
            PlayerStats.PlayerLives = 0;
        }
        else
        {
            PlayerStats.PlayerLives = PlayerStats.PlayerLives - damageAmount;         //Deals the amount of damage in EnemyModel.Damage
        }
        if (PlayerStats.PlayerLives == 0)
        {
            GameOver gameOver = FindObjectOfType<GameOver>();   //Finds the GameOver class in GameMaster
            gameOver.EndGame();                                 //Calls the "EndGame" function, ending the game
        }
    }
}
