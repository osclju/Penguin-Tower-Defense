using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isDead : MonoBehaviour
{
  
    [SerializeField] public int hp;

    // Kan göra listor av dessa så att skeppen har flera effective och immuninty
    [SerializeField] public int immunity;
    [SerializeField] public int superEffective;
    
    // Update is called once per frame
    void Update()
    {
        if(hp <= 0)
        {
            Debug.Log("DEAD");
            Destroy(gameObject);
        }
    }
}
