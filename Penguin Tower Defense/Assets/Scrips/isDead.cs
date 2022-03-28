using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class isDead : MonoBehaviour
{
  
    [SerializeField] public int hp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hp <= 0)
        {
            GameObject g = GameObject.Find("Coins");
            g.GetComponent<coins>().Coins+=20;
            Debug.Log("DEAD");
            Destroy(gameObject);
        }
    }
}
