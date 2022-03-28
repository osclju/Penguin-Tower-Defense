using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    
    public GameObject tower;
    public GameObject RangeView;


    [SerializeField][Range(1f, 3f)] float TowerFootprint = 2f;
    public bool isDragging = false;
    public bool SafeToPlace = false;


    private void Awake()
    {
        RangeView.SetActive(false);
    }


    public void OnMouseDown()
    {
        if(isDragging == false) { 
            if (gameObject.GetComponent<DragAndDrop>().enabled == true)
            {
                RangeView.SetActive(true);

                //RangeView.GetComponent<RangeScript>().enabled = true;
                Instantiate(tower, transform.position, Quaternion.identity);
                isDragging = true;
            }
        }




    }

    public void OnMouseUp()
    {

        Debug.Log(SafeToPlace);

        if(SafeToPlace == true) { 
            isDragging = false;
            RangeView.SetActive(false);
            this.GetComponent<TowerMenu>().enabled = true;
            //RangeView.GetComponent<RangeScript>().enabled = false;
            gameObject.GetComponent<DragAndDrop>().enabled = false;
            gameObject.GetComponent<TowerSeeking>().enabled = true;
        }
    }

    void FixedUpdate()
    {
        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);

            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, TowerFootprint, 1, 0);

            SafeToPlace = true;
            for (int i = 0; i < colliders.Length; i++)
            {
                if (colliders[i].name != gameObject.name && (colliders[i].tag == "Track" || colliders[i].tag == "Tower"))
                {
                    SafeToPlace = false;
                    break;
                }
            }

        }
    }


    void OnDrawGizmosSelected()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, TowerFootprint);
    }



}