using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    float ContollX, ContollY;

    public Sprite newImage;
    private Image myIMGcomponent;

    void Start()
    {
        myIMGcomponent = this.GetComponent<Image>();
        myIMGcomponent.sprite = newImage;
    }

    // Update is called once per frame
    void Update()
    {
        ContollX = Input.GetAxisRaw("Horizontal");
        ContollY = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        if (ContollX == -1) //Left
        {
            Debug.Log("left");
        }
        else if (ContollX == 1) //Right
        {
            Debug.Log("Right");
        }
        else if (ContollY == 1) //UP
        {
            Debug.Log("UP");
        }
        else if (ContollY == -1) //Down
        {
            Debug.Log("NEd");
        }
    }
    
    public void SelectLevel_picture_left()
    {
        
    }
}
