using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject angelPrefab;
    public GameObject devilPrefab;
    float enemySpawnTime = 2.0f;// = 10.0f;
    float curTime = 0.0f;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curTime = curTime + Time.deltaTime;
        if(curTime>=enemySpawnTime)
        {
            GameObject spawnedAngle = GameObject.Instantiate(angelPrefab, new Vector3(0,10,0), Quaternion.identity);
            spawnedAngle.GetComponent<EnemyMovementController>().setEnemyTarget(player);
            //Instantiate(devilPrefab, new Vector3(0,-10,0), Quaternion.identity);
            curTime = 0.0f;
        }
    }
}
