using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAim : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 mousePos;
    public Camera cam;

    void FixedUpdate()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg + 90f;
        // rb.rotation = angle;
        rb.MoveRotation(angle);
    }

}
