using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
    public Enemy enemy;
    Vector3 localScale;
    void Start()
    {
        localScale = transform.localScale;
    }


    void Update()
    {
        localScale.x = enemy.health/100;
        transform.localScale = localScale;
    }
}
