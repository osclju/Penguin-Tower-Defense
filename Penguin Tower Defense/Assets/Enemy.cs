using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        var storpingvin = collision.GetComponent<Storpingvin>();
        if (storpingvin)
        {
            Debug.Log("has collide");
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
