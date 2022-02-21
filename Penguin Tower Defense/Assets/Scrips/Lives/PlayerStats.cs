using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private static int m_PlayerLives;
    [SerializeField] private int startLives = 20; 


    void Start()
    {
        m_PlayerLives = startLives;
    }

    public static int PlayerLives
    {
        get { return m_PlayerLives; }
        set { m_PlayerLives = value; }
    }
    

}
