using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    Scene level;
    int AmountofLevels;

    private void Awake()
    {
        // Kontrollerar s� endast en LevelLoader kan existera
        GameObject[] objs = GameObject.FindGameObjectsWithTag("KeepAlive");
        if (objs.Length > 1) {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        //H�mtar totalla antalet scener
        AmountofLevels = SceneManager.sceneCountInBuildSettings;

    }
    private void FixedUpdate()
    {
        if (this.enabled) //Om scriptet �r p�
        {
            this.enabled = false;
            LoadNextLevel();
        }
    }

    public void LoadNextLevel() //Loads nextlevel
    {
        // H�mtar laddad scen
        level = SceneManager.GetActiveScene();
        if ( (level.buildIndex + 1) < AmountofLevels)
        {
            SceneManager.LoadScene(1 + level.buildIndex);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
        
    }

    public void LoadSelectedLevel(int levelIndex) {
        SceneManager.LoadScene(levelIndex);
    }

    public void LoadMenu() {
        SceneManager.LoadScene(0);
    }

    public void RestartLevel() {
        SceneManager.LoadScene(level.buildIndex);
    }

}
