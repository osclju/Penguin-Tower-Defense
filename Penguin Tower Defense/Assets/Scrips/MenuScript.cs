using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    static int selectedLevel = 1;
    int amountOfLevles;
    float ContollX, ContollY;
    

    public Sprite newImage;
    [SerializeField] Sprite[] Maps;

    [SerializeField] Image myIMGcomponent1;
    [SerializeField] Image myIMGcomponent2;
    [SerializeField] Image myIMGcomponent3;

    void Start()
    {
        amountOfLevles = SceneManager.sceneCountInBuildSettings;
        Debug.Log(amountOfLevles);
        myIMGcomponent1.sprite = newImage;
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
        
        if (selectedLevel < amountOfLevles)
        {
            selectedLevel++;
        }
        else {
            selectedLevel = 1;
        }

        if (selectedLevel > 1)
        {
            //Picture Switch                                  selected = 2
            myIMGcomponent1.sprite = Maps[selectedLevel - 2]; // [0]
            myIMGcomponent2.sprite = Maps[selectedLevel - 1]; // [1]
            myIMGcomponent3.sprite = Maps[selectedLevel];     // [2]
        }
        else {
            //Picture Switch                                  selected
            myIMGcomponent1.sprite = Maps[amountOfLevles - 1]; // [4]
            myIMGcomponent2.sprite = Maps[selectedLevel - 1]; // [0]
            myIMGcomponent3.sprite = Maps[selectedLevel];     // [1]
        }
        
        Debug.Log(selectedLevel);
    }
    public void SelectLevel_picture_right()
    {
        if (selectedLevel > 1)
        {
            selectedLevel--;
        }
        else
        {
            selectedLevel = amountOfLevles;
        }

        if (selectedLevel > 1)
        {
            //Picture Switch                                  selected = 2
            myIMGcomponent1.sprite = Maps[selectedLevel - 2]; // [0]
            myIMGcomponent2.sprite = Maps[selectedLevel - 1]; // [1]
            myIMGcomponent3.sprite = Maps[selectedLevel];     // [2]
        }
        else
        {
            //Picture Switch                                  selected
            myIMGcomponent1.sprite = Maps[amountOfLevles - 1]; // [4]
            myIMGcomponent2.sprite = Maps[selectedLevel - 1]; // [0]
            myIMGcomponent3.sprite = Maps[selectedLevel];     // [1]
        }

        Debug.Log(selectedLevel);
    }
}
