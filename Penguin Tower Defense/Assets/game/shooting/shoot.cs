using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject fp; 
    [SerializeField]
    private Rigidbody2D bulletPrefab;
    private Rigidbody2D pew;

    private Vector3 pos;
    private Vector3 angle;

    void Start()
    {
        fp = GameObject.Find("firePoint");
    }

    // Update is called once per frame
    void Update()
    {
        pos = fp.transform.position;
        angle = fp.transform.eulerAngles;
        angle += new Vector3(0, 0, 90);
        Debug.Log(angle);
        if (Input.GetKeyDown("space")) {
            shooting();
        }
    }
    private void shooting() {
        Debug.Log("pew");
        pew = Instantiate(bulletPrefab, pos, Quaternion.Euler(angle));
        pew.AddForce(new Vector2(20, 0));
        kill();
    }
    private void kill() { 
    
    }
}
