using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public int count;
    public int timer;
    public int spawnRate;
    public GameObject enemy;

    void Start()
    {
        count = 1;
        spawnRate = 1;
        timer = 1000;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        count += spawnRate;
        if (count >= timer)
        {
            GameObject effect = Instantiate(enemy, transform.position, Quaternion.identity);
            count = 0;
        }
    }
}
