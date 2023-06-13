using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    private  int timer;
    private int count;

    public float bulletForce = 10f;
    void Start()
    {
        timer = 200;
        count = 1;

    }

    void FixedUpdate()
    {
        count++;
        if (count>=timer)
        {
            Shoot();
            count = 1;
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(-firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}

