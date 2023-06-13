using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public Enemy enemy;
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float moveSpeed;
    private bool enemyMoves;
    public Transform firePoint;
    public GameObject bulletPrefab;
    private int timer;
    private int count;
    public float bulletForce = 10f;
    public float AggroRange;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        timer = 70;
        count = 1;
       // AggroRange = 12;
        this.moveSpeed = enemy.speed;
    }
    void Update()
    {
        Vector2 direction = player.position - transform.position;
        if (direction[1] < AggroRange && direction[0] < AggroRange && direction[1] > -AggroRange && direction[0] > -AggroRange)
        {

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg +90f;
            //rb.rotation = angle + 90;
          //  firePointRB.MoveRotation(angle);
            direction.Normalize();
            movement = direction;

            enemyMoves = true;

        }
        else
        {
            enemyMoves = false;
        }
    }
    void FixedUpdate()
    {
        if (enemyMoves)
        {
            moveCharacter(movement);
            ShootingCounter();
        }
    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }


    void ShootingCounter()
    {
        count++;
        if (count >= timer)
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
