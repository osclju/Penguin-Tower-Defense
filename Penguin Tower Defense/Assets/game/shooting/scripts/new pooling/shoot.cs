using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OWS.ObjectPooling;

public class shoot : MonoBehaviour
{    
    // skjuta prefabsen
    private Transform fp; 
    //[SerializeField]  
    //private GameObject bulletPrefab;
    //private GameObject clone;
    private Rigidbody2D pew;

    // punkt att skjutas ifrån
    private Vector3 pos;
    private Vector3 angle;

    // variabler från bullets
    private float b_speed;
    private float b_timeBetweenShoots;
    private float b_range;
    private bool shootingStopped = false;

    // time
    private float timeChange = 1;

    // pooling
    private static MyObjectPool<PoolObject> bulletPool;
    [SerializeField] private GameObject objPrefab;
    
    // pooling
    /*
    [SerializeField]
    private float timeToSpawn = 5f;
    private float timeSinceSpawn;
    private objectPool objectPool;
    [SerializeField]
    private GameObject prefab;
    */
    private void Awake()
    {
        bulletPool = new MyObjectPool<PoolObject>(objPrefab, 2);
    }
    void Start()
    {
        fp = transform.Find("firePoint");
        //hämtar alla variabler från bullet
        b_speed = objPrefab.GetComponent<bulletVar>().speed;
        b_timeBetweenShoots = objPrefab.GetComponent<bulletVar>().timeBetweenShots;
        b_range = objPrefab.GetComponent<bulletVar>().timeLeft / 2;
       
        if (b_timeBetweenShoots < 1)
        {
            timeChange = 0.1f;
        }
        // pooling
        //objectPool = FindObjectOfType<objectPool>();
    }
    private void Update()
    {
        // pooling
        /*
        timeSinceSpawn += Time.deltaTime;
        if (timeSinceSpawn >= timeToSpawn) {
            GameObject clone = objectPool.GetObject(prefab);
            clone.transform.position = this.transform.position;
            timeSinceSpawn = 0f;
        }
        */

        // För testing, kan ta bort detta sen när det fungerar
        if (Input.GetKeyDown("space"))
        {
            startShooting();
        }
        else if(Input.GetKeyDown("return"))
        {
            Debug.Log("you have stopped");
            stopShooting();
        }
    }

    public void startShooting() {
        shootingStopped = false;
        shooting();
        StartCoroutine(Countdown());
    }
    public void stopShooting()
    {
        shootingStopped = true;
    }
    private IEnumerator Countdown()
    {
        // add arrays 
        float duration = b_timeBetweenShoots; // 3 seconds you can change this 
                                     //to whatever you want

        while (duration > 0f)
        {
            if (shootingStopped){
                yield break;
            }
            else {
                yield return new WaitForSeconds(timeChange);
            }

            duration -= timeChange;
        }
        shooting();
        StartCoroutine(Countdown());
    }

    public void shooting() {
        
        /* Detta borde fungera */ 
       
        // räknar ur posiiton och rikting där projectilen ska skjutas 
        pos = fp.position;
        angle = fp.transform.eulerAngles;
        angle += new Vector3(0, 0, 90);
        // skapar en klon av bullet prefab som skjuts iväg
        /*
        clone = Instantiate(bulletPrefab, pos, Quaternion.Euler(angle));
        */
        // ger en relativ force rakt uppåt, så det hållet som vapnet pekar

        GameObject poolClone = bulletPool.PullGameObject(pos);
        pew = poolClone.GetComponent<Rigidbody2D>();
        pew.transform.rotation = Quaternion.Euler(angle);
        pew.AddRelativeForce(new Vector2(0, b_speed), ForceMode2D.Force);

        pew.AddForceAtPosition()
    }
    // special effect 

    // i enemie titta vad det är fär effect på den kulan, om det är samma effekt som fienden gör detta
    // if(effekt == myEffekt){
    //  Do nothing 
    // or do all
    // }
}
