using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletVar : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
    public int dmg;
    [SerializeField][Range(0f, 5f)]
    public float timeBetweenShots;
    public int affect;
    [SerializeField]
    [Range(0f, 10f)]
    public float maxDistance;

    private Vector2 startCord;
    private Vector2 currentCord;
    private float diff;
    private void Start()
    {
       startCord = gameObject.GetComponent<Rigidbody2D>().transform.position;
    }
    private void Update() {
        currentCord = gameObject.GetComponent<Rigidbody2D>().transform.position;
        diff = Vector2.Distance(startCord, currentCord);
        if (diff > maxDistance) {
            gameObject.SetActive(false);
        }
    }
   
}
