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
            Destroy(collision.gameObject);
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
