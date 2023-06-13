using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class Shooting : MonoBehaviour
{ 
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject Tile;
    public float bulletForce = 20f;
    public bool click;
    public float FireRate = 50f;
    public float FireCount = 100f;
    public float Fire = 100f;
    public Player player;
    public bool tilePlaced;

    void Start()
    {
        click = false;
        Scene scene = SceneManager.GetActiveScene();
    }


    void Update()
    {
        if (Input.GetMouseButton(0) && !IsMouseOverUI())
        {
            click = true;
        }
        else
        {
            click = false;
            tilePlaced = false;
        }
    }


    void FixedUpdate()
    {
        if (player.ShootActive)
        {
            if (click)
            {
                if (FireCount >= Fire)
                {
                    Shoot();
                    FireCount = 0f;
                }
                else
                {
                    FireCount += FireRate;
                }
            }
            else
            {
                FireCount = 100f;
            }
        }
        else if(player.TileSelected)
        {
            if (click && !tilePlaced)
            {
                TilePlace();
                tilePlaced = true;
            }
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb =  bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(-firePoint.up * bulletForce, ForceMode2D.Impulse);
    }

    void TilePlace()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 2.0f;      
        Vector3 objectPos = Camera.current.ScreenToWorldPoint(mousePos);
        GameObject tile = Instantiate(Tile, objectPos, Quaternion.identity);

    }

    private bool IsMouseOverUI()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }
    
}
