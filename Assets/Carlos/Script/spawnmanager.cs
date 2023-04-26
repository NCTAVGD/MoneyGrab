using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    public GameObject[] moneyPrefabs;
    public Transform[] spawnpoints;
    public int enemyindex;
    public float spawnTime = 5f;
    public float spawnDelay = 3f;

    public float xMin;
    public float xMax;

    public float yMin;
    public float yMax;

    // Start is called before the first frame update
    void Start()
    {
        //4.) InvokeRepeating to keep spawning
        InvokeRepeating("SpawnEnemy", spawnDelay, spawnTime);
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void SpawnEnemy()
    {
        int moneyindex = Random.Range(0, moneyPrefabs.Length);
        //1.) Pick a random enemy
        Vector3 randomSpawnPosition = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 0);

        //2.) Pick a random spawn point
        /*int spawnpoint = Random.Range(0, spawnpoints.Length);*/
        //3.) Spawn that enemy at that spawn point

        Instantiate(moneyPrefabs[moneyindex], randomSpawnPosition, Quaternion.identity);
    }
}


