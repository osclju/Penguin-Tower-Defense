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
    List<int> Enemyint = new List<int>();

    public GameObject Ship;




    private void Start()
    {

       Vector2 pos1 = GameObject.Find("p").transform.position;
       Vector2 pos2 = GameObject.Find("p (1)").transform.position;

       SpawnPos = pos1 - pos2;





    }


    private void OnMouseUp()
    {
        if(WaveRunning == false) {

            WaveRunning = true;

            switch (CurrentRound)
            {
                case 1:
                    Enemyint = new List<int> { 1, 1, 1, 1, 1, 1 };
                    break;
                case 2:
                    Enemyint = new List<int> { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
                    break;
                default:
                    Enemyint = new List<int> { 1, 1, 1, 1, 1, 1 };
                    break;
            }

            StartCoroutine(waiter());





        }

    }



    IEnumerator waiter()
    {

        int listSize = Enemyint.Count;
        for (int i = 0; i < listSize; i++)
        {

            Debug.Log(i);

            //Ship = (GameObject)Resources.Load("prefabs/Enemies/Ship1", typeof(GameObject));

            GameObject EnemyShip = Instantiate(Ship, SpawnPos, Quaternion.identity);

            WaveEnemies.Add(EnemyShip);
            
            timer += Time.deltaTime;
            Debug.Log(timer);

            //yield return new WaitForSeconds(0.5f);
            yield return new WaitForSeconds(2);

        }

        //Wait for 2 seconds
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
