using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectPool : MonoBehaviour
{
    // Start is called before the first frame update

    /*
    [SerializeField]
    private GameObject bulletPerfab;
    [SerializeField]
    private Queue<GameObject> bulletPool = new Queue<GameObject>();
    [SerializeField]
    private int poolStartSize = 500;

    private void Start()
    {
        for (int n = 0; n < poolStartSize; n++) {
            GameObject bullet = Instantiate(bulletPerfab);
            bulletPool.Enqueue(bullet);
            bullet.SetActive(false);
        
        }
    }
    public GameObject getBullet() {
        if (bulletPool.Count > 0)
        {
            GameObject bullet = bulletPool.Dequeue();
            bullet.SetActive(true);
            return bullet;
        }
        else {
            GameObject bullet = Instantiate(bulletPerfab);
            return bullet;
        }
    }
    public void ReturnCritter(GameObject bullet) {
        bulletPool.Enqueue(bullet);
        bullet.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */

    private Dictionary<string, Queue<GameObject>> Pool = new Dictionary<string, Queue<GameObject>>();

    public GameObject GetObject(GameObject Object) {
        if (Pool.TryGetValue(gameObject.name, out Queue<GameObject> objectList){
            if (objectList.Count == 0)
            {
                return CreateNewObject(Object);
            }
            else {
                GameObject _object = objectList.Dequeue();
                _object.SetActive(true);
                return _object;
            }
        }
        else
            return CreateNewObject(Object);
    }

    private GameObject CreateNewObject(GameObject gameObject) {

        GameObject newGO = Instantiate(gameObject);
        newGO.name = gameObject.name;
        return newGO;
    }

    public void ReturnGameObject(GameObject gameObject) {

        if (Pool.TryGetValue(gameObject.name, out Queue<GameObject> objectList))
        {
            objectList.Enqueue(gameObject);
        }
        else {
            Queue<GameObject> newObjectQueue = new Queue<GameObject>();
            newObjectQueue.Enqueue(gameObject);
            Pool.Add(gameObject.name, newObjectQueue);
        }

        gameObject.SetActive(false);
    
    }
}
