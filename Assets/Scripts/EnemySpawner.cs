using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    GameObject angel;
    GameObject devil;
    float enemySpawnTime;// = 10.0f;
    float curTime = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        enemySpawnTime = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        enemySpawnTime = enemySpawnTime + Time.deltaTime;
        if(curTime>=enemySpawnTime)
        {
            Instantiate(angel, new Vector3(0,10,0), Quaternion.identity);
            Instantiate(devil, new Vector3(0,-10,0), Quaternion.identity);
            curTime = 0.0f;
        }
    }
}
