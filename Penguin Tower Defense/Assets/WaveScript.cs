using System.Collections;
using System.Collections.Generic;
//using static System.Collections.IEnumerable;

using UnityEngine;

public class WaveScript : MonoBehaviour
{
    int CurrentRound = 1;
    bool WaveRunning = false;

    float timer = 0;

    Vector2 SpawnPos;
    List<GameObject> WaveEnemies = new List<GameObject>();
    List<List<int>> Enemyint;

    //public GameObject Ship;

    private void Awake()
    {

        var WaveText = Resources.Load("Waves") as TextAsset; ;
        //string[] AllWords = ReadAllLines(Application.streamingAssetsPath, "Waves.txt");

        string[] tmpWave = WaveText.text.Split('-');


        //int yeh;





        // List<int>.Parse(WaveText.text.Split('\n'), tmpWave);
        Debug.Log(WaveText);
    }


    private void Start()
    {
       Vector2 pos1 = GameObject.Find("p").transform.position;
       Vector2 pos2 = GameObject.Find("p (1)").transform.position;
       SpawnPos = pos1 - pos2;
    }


    private void OnMouseUp()
    {
        if(!WaveRunning) {

            WaveRunning = true;
            /*
            switch (CurrentRound)
            {
                case 1:
                    Enemyint = new List<int> { 1, 1, 2};
                    break;
                case 2:
                    Enemyint = new List<int> { 1, 2};
                    break;
                default:
                    Enemyint = new List<int> { 1, 1, 1, 1, 1, 1 };
                    break;
            }
            */
            StartCoroutine(waiter());
        }

    }

    IEnumerator waiter()
    {
        int listSize = Enemyint.Count;
        for (int i = 0; i < listSize; i++)
        {

            Debug.Log(Enemyint[i]);

            GameObject EnemyShip = Instantiate((GameObject)Resources.Load("Enemies/Ship"+Enemyint[i].ToString(), typeof(GameObject)), SpawnPos, Quaternion.identity);

            WaveEnemies.Add(EnemyShip);
            timer += Time.deltaTime;
            yield return new WaitForSeconds(2);
        }
        //Wait for 2 seconds
    }



    // Update is called once per frame
    void FixedUpdate()
    {

        if (WaveRunning) { 
            int enemiesAmount = WaveEnemies.Count;
            bool cleared = true;
            for (int i = 0; i < enemiesAmount; i++)
            {
                if (WaveEnemies[i] == null && WaveEnemies.Count == Enemyint.Count)
                {

                }
                else { cleared = false; break; }
            }

            if (cleared == true)
            {
                WaveRunning = false;
                WaveEnemies.Clear();
                CurrentRound++;
            }

        }

        //color.color = new Color32(145, 0, 0, 165);

        if (WaveRunning)
        {
            GetComponent<SpriteRenderer>().material.color = new Color32(32, 32, 32, 255); ;
        }
        else
        {
            GetComponent<SpriteRenderer>().material.color = new Color32(40, 217, 161, 255); ;
        }


    }
}
