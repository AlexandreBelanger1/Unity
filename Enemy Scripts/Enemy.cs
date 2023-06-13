using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Player player;
    public GameObject EnemyBody;
    public float health;
    public float maxhealth;
    public float level;
    public float speed;
    public float[] EnemyInputArray = new float[3];
    public Animator animator;

    void Start()
    {
        InitializeEnemy(EnemyInputArray[0], EnemyInputArray[1], EnemyInputArray[2]);
    }

    void Update()
    {
        animator.SetFloat("HealthPercent", health/maxhealth);
        if (health <= 0)
        {
            Destroy(EnemyBody);
            player.experience += (25 * level);
        }
    }
    public void InitializeEnemy(float hp, float lv, float spd)
    {
        this.health = hp;
        this.level = lv;
        this.speed = spd;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.rigidbody.tag == "PlayerBullet")
        {
            this.health = this.health - (20 + (5 * player.level));
        }
        else 
        {
            Physics2D.IgnoreLayerCollision(0, 23, true);
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        
    }
}