using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSelect : MonoBehaviour
{
    public GameObject tower;
    private int NumberOfType = 1;

    // Start is called before the first frame update
    public void OnMouseDown()
    {

        Debug.Log(NumberOfType);
        NumberOfType++;
    }
}
}
