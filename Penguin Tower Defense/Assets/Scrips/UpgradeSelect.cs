using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSelect : MonoBehaviour
{
    private GameObject Tower;
    // Start is called before the first frame update
    public void OnMouseDown()
    {

        Debug.Log("Pressed ID: "+ this.gameObject.transform.name);
        
        foreach (Transform eachChild in transform)
        {
            if (eachChild.name == "RangeVisual")
            {
                if (eachChild.gameObject.activeSelf) {
                    FindObjectOfType<GameUI>().SetUpgradeWindow(false);
                    eachChild.gameObject.SetActive(false);
                }
                else
                {
                    FindObjectOfType<GameUI>().setTower(this.gameObject);
                    FindObjectOfType<GameUI>().SetUpgradeWindow(true);
                    eachChild.gameObject.SetActive(true);
                }
            }
        }
    }

    public void DeleteTower() {
        Debug.Log("Deleted ID:" + this.gameObject.transform.name);
        GameObject.Destroy(this.gameObject);
    }

    public void SetTower(GameObject tower) {
        Tower = tower;
    }
    public Transform GetTower()
    {
        return(this.transform);
    }
}
