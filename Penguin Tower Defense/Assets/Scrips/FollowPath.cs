using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    int currentpos = 1;
    float speed = 2f;
    bool ded = false;
    [SerializeField]Transform[] a;
    GameObject temp;
    void Start() {
        temp = GameObject.FindGameObjectWithTag("Path");
        a = temp.GetComponentsInChildren<Transform>();
    }
    void Update()
    {
        if (ded == false&&transform.position == a[currentpos].position) {
            currentpos++;
        }
        if (currentpos == a.Length) {
            Debug.Log("DÖD");
            ded = true;
        }
        else {
            transform.position = Vector2.MoveTowards(transform.position, a[currentpos].position, speed * Time.deltaTime);
            rotera();
        }
       
        
    }
    void rotera() {
        float dy = a[currentpos].position.y - transform.position.y;
        float dx = a[currentpos].position.x - transform.position.x;
        Vector2 dir = new Vector2(dx, dy);
        // The step size is equal to speed times frame time.
        float singleStep = 500 * Time.deltaTime;

        Quaternion targetrot = Quaternion.LookRotation(Vector3.forward, dir);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetrot, singleStep);
    }
}
