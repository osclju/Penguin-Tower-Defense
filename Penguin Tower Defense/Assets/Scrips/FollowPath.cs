using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    int currentpos = 1;
    float speed = 10f;
    bool ded = false;
    [SerializeField]Transform[] a;
    GameObject temp;
    void Start() {
        temp = GameObject.FindGameObjectWithTag("Path");
        a = temp.GetComponentsInChildren<Transform>();
    }
    void Update()
    {
        if (ded == false&&gameObject.transform.position == a[currentpos].position) {
            currentpos++;
        }
        if (currentpos == a.Length) {
            EnemyController ec = gameObject.GetComponent<EnemyController>();
            ec.DealDamage();
            Debug.Log("EnemyIsDead");
            ded = true;
            Destroy(gameObject);
        }
        else {
            gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, a[currentpos].position, speed * Time.deltaTime);
            rotera();
        }
       
        
    }
    void rotera() {

    }
    
}
