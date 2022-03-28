using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeScript : MonoBehaviour
{
    public GameObject Parent;
    public SpriteRenderer color;

    public float Range;
    public bool IsDragging;
    public bool SafeToPlace;


    // Update is called once per frame
    void FixedUpdate()
    {
        
        SafeToPlace = Parent.GetComponent<DragAndDrop>().SafeToPlace;
        IsDragging = Parent.GetComponent<DragAndDrop>().isDragging;
        Range = 2 * Parent.GetComponent<TowerSeeking>().Range;
        transform.localScale = new Vector3(Range, Range, 0);
        


        if (IsDragging == true) { 


            if(SafeToPlace == false)
            {
                color.color = new Color32(145, 0, 0, 165);
            }
            else
            {
                color.color = new Color32(32, 32, 32, 165);
            }


        }
    }
}
