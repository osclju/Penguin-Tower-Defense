using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{

    public float HowFarIn = 0;

    int currentpos = 1;
    [SerializeField][Range(1, 10)]float speed = 2f;
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
            Debug.Log("DÖD");
            ded = true;
        }
        else {
            HowFarIn += speed * Time.deltaTime;
            gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, a[currentpos].position, speed * Time.deltaTime);
            rotera();
        }
       
        
    }
    void rotera() {

    }
}
