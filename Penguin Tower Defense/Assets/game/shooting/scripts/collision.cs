using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    int dmg, affect; 
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pirate") {
            dmg = gameObject.GetComponent<bulletVar>().dmg;
            affect = gameObject.GetComponent<bulletVar>().affect;
            Debug.Log("Damage taken: " + dmg + " and affect: " + affect);
            Destroy(gameObject);
        }
    }
}
