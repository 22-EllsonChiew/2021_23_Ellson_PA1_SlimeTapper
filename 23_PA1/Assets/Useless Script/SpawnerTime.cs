using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTime : MonoBehaviour
{

    public GameObject spawner;
    public bool stopSpawing = false;
    public float spawnTime;
    public float spawnDelay;




    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnObject()
    {
        Instantiate(spawner, transform.position, Quaternion.identity);
        if(stopSpawing)
        {
            CancelInvoke("spawnObject");
        }
    }
}
