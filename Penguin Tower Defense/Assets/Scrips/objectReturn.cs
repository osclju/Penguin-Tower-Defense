using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectReturn : MonoBehaviour
{
    private objectPool objectPool;
    
    // Start is called before the first frame update
    
    void Start()
    {
        objectPool = FindObjectOfType<objectPool>();
    }

    private void OnDisable()
    {
        if (objectPool != null) {
            objectPool.ReturnGameObject(this.gameObject);
        }
    }
}  
