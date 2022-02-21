using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject fp; 
    [SerializeField]
    private GameObject bulletPrefab;
    private GameObject clone;
    private Rigidbody2D pew;

    private Vector3 pos;
    private Vector3 angle;
    [SerializeField]
    private float speed = 2000f;


    void Start()
    {
        fp = GameObject.Find("firePoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) {
            pos = fp.transform.position;
            angle = fp.transform.eulerAngles;
            angle += new Vector3(0, 0, 90);
            shooting();
        }
    }
    private void shooting() {
        Debug.Log("pew");
        clone = Instantiate(bulletPrefab, pos, Quaternion.Euler(angle));
        pew = clone.GetComponent<Rigidbody2D>();
        pew.AddRelativeForce(new Vector3(0, -speed), ForceMode2D.Force);
        
        kill();
    }
    private void kill() { 
    
    }
}
