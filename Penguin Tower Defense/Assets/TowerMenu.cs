using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerMenu : MonoBehaviour
{
    public GameObject RangeView;
    bool MenuIsOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnMouseDown()
    {

        if (MenuIsOpen == false) { 
               // RangeView.SetActive(true);
                MenuIsOpen = true;
        }
        else
        {
            //RangeView.SetActive(false);
            MenuIsOpen = false;
        }




    }

}
