using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] Image Font_window;
    [SerializeField] Sprite[] Turret_pictures_down;
    [SerializeField] Sprite[] Turret_pictures_front;
    [SerializeField] Image[] Turret_objects;
    [SerializeField] GameObject ResourcesMain;
    [SerializeField] GameObject UpgradeMain;
    static bool Visable = false;

    private void Awake()
    {
        for (int i = 0; i < Turret_pictures_down.Length; i++)
        {
            Turret_objects[i].sprite = Turret_pictures_down[i];
        }
        
    }

    public void upgrade(int pressed)
    {
        Font_window.sprite = Turret_pictures_front[pressed];
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToggleResources() {
        if (ResourcesMain.activeSelf)
        {
            ResourcesMain.SetActive(false);
        }
        else
        {
            ResourcesMain.SetActive(true);
        }
    }
    public void ToggleUpgradeWindow()
    {
        if (UpgradeMain.activeSelf)
        {
            UpgradeMain.SetActive(false);
        }
        else
        {
            UpgradeMain.SetActive(true);
        }
    }
}
