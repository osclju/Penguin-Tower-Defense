using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    private void Start() { 
    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("träff");
        Destroy(gameObject);

    }
}
