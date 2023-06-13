using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_Player_Hit : MonoBehaviour
{
    public Player player;
    public string[][] BulletType;

    void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.rigidbody.tag == "EnemyBullet")
        //{
        //   player.health = player.health - 25;
        //}
        DamageCalculator(collision.rigidbody.tag);

        // else //if (collision.rigidbody.tag == "PlayerBullet")
        
            Physics2D.IgnoreLayerCollision(21, 22, true);
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        
    }

    void DamageCalculator(string tag)
    {
        if (tag == "SlimeBullet")
        {
            player.health -= 25;
                return;
        }
    }
}