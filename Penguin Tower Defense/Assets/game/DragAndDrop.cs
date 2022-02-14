using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    
    public Transform tower;
    private bool isDragging;

    public void OnMouseDown()
    {
        
        if (gameObject.GetComponent<DragAndDrop>().enabled != false)
        {
            Instantiate(tower, transform.position, Quaternion.identity);
            isDragging = true;
        }
    }

    public void OnMouseUp()
    {
        isDragging = false;
        gameObject.GetComponent<DragAndDrop>().enabled = false;
        gameObject.GetComponent<TowerSeeking>().enabled = true;
    }

    void Update()
    {
        
        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }
}