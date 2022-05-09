using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSelect : MonoBehaviour
{
    static private int NumberOfType = 1;
    private int TowerID;

    // Start is called before the first frame update
    public void OnMouseDown()
    {
        Debug.Log("Pressed");
        FindObjectOfType<GameUI>().ToggleUpgradeWindow();
        foreach (Transform eachChild in transform)
        {
            if (eachChild.name == "RangeVisual")
            {
                if (eachChild.gameObject.activeSelf) {
                    eachChild.gameObject.SetActive(false);
                }
                else
                {
                    eachChild.gameObject.SetActive(true);
                }
            }
        }
    }

    public void DeleteTower() {
        GameObject.Destroy(this.gameObject);
    }

    public void SetTowerID(int id) {
        TowerID = id;
    }
    public int GetTowerID()
    {
        return(TowerID);
    }
}
