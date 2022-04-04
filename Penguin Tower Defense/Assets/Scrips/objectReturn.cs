using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
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
        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
