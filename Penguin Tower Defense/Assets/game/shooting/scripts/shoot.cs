using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{    
    // skjuta prefabsen
    private Transform fp; 
    [SerializeField]  
    private GameObject bulletPrefab;
    private GameObject clone;
    private Rigidbody2D pew;

    // punkt att skjutas ifrån
    private Vector3 pos;
    private Vector3 angle;

    // variabler från bullets
    private float b_speed;
    private float b_dmg;
    private float b_firerate;
    private int b_affect;

    void Start()
    {
        fp = transform.Find("firePoint");
        //hämtar alla variabler från bullet
        
        b_dmg = bulletPrefab.GetComponent<bulletVar>().dmg;
        b_speed = bulletPrefab.GetComponent<bulletVar>().speed;
        b_firerate = bulletPrefab.GetComponent<bulletVar>().firerate;
        b_affect = bulletPrefab.GetComponent<bulletVar>().affect;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) {
            pos = fp.position;
            angle = fp.transform.eulerAngles;
            angle += new Vector3(0, 0, 90);
            shooting();
        }
    }
    private void shooting() {
       
        clone = Instantiate(bulletPrefab, pos, Quaternion.Euler(angle));
        pew = clone.GetComponent<Rigidbody2D>();
        pew.AddRelativeForce(new Vector3(0, -b_speed), ForceMode2D.Force);
        
        Invoke("kill", 2f);
    }

    // firerate

    // special effect 

    // damage controll

    // dont kill eachother

    // kunna skjuta 

    private void kill() {
        Destroy(clone);
    }
}
