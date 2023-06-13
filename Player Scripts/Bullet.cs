using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject HitEffect;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Physics2D.IgnoreLayerCollision(23, 22, true);
        GameObject effect = Instantiate(HitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 5f);
            Destroy(gameObject);
    }
    void Start()
    {
        Destroy(gameObject, 1f);
      //  StartCoroutine(BulletDestroyTime(3.0f));
    }
    //IEnumerator BulletDestroyTime(float delay)
    //{
    //    yield return new WaitForSeconds(delay);
    //    Destroy(gameObject);
    //}
}
