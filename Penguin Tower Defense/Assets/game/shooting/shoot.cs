using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform fp; 
    [SerializeField]
    private GameObject bulletPrefab;
    private GameObject clone;
    private Rigidbody2D rb;

    private Vector3 pos;
    private Vector3 angle;

    private bool gunexpl;

    void Start()
    {
        fp = transform.Find("firePoint");
    }

    // Update is called once per frame
    void Update()
    {
        pos = fp.transform.position;
        angle = fp.transform.eulerAngles;
        angle += new Vector3(0, 0, 90);
        if (Input.GetKeyDown("space"))
        {
            gunexpl = true;
        }
    }
    private void FixedUpdate()
    {
        if (gunexpl != true) return;
        
        gunexpl = false;
        shooting();
    }
    private void shooting() {
        Debug.Log("pew");
        clone = Instantiate(bulletPrefab, pos, Quaternion.Euler(angle));
        rb = clone.GetComponent<Rigidbody2D>();                                 // fungerar typ yeeeeee
        rb.AddForce(angle + new Vector3(2000, 0), ForceMode2D.Impulse);
        
        
        /*
        pew = GetComponent<Rigidbody2D>();
        pew.AddForce(new Vector2(200,200));
        pew.transform.
        */
    }
}
