using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyModel : BaseEnemy
{

    void Start()
    {
        damage = 10;
        health = 10;
        speed = 1f;
        Debug.Log("Damage set");
        Debug.Log(Damage); 
    }
    public int Damage
    {
        get { return damage; }
        private set { damage = value; }
    }
    public int Health
    {
        get { return health; }
        set { health = value; }
    }
    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }

}
