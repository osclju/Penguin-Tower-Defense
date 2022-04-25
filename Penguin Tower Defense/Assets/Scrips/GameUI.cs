using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] Image Upgrade_Window;
    [SerializeField] Sprite[] Turret_pictures_down;
    [SerializeField] Sprite[] Turret_pictures_front;
    [SerializeField] Image[] Turret_objects;
    [SerializeField] GameObject ResourcesMain;
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
        Upgrade_Window.sprite = Turret_pictures_front[pressed];
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
}
