using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public int Coins;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
        GetComponent<UnityEngine.UI.Text>().text = "" +Coins;
    }
}
