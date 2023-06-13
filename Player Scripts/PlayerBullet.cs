using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public GameObject HitEffect;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.rigidbody.tag != "Player")
        {
            GameObject effect = Instantiate(HitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.3f);
            Destroy(gameObject);
        }
    }
    void Start()
    {
        Destroy(gameObject, 0.5f);
    }
}
