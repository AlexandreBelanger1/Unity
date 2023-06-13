using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAim : MonoBehaviour
{
    public Rigidbody2D rbPlayer;
    public Rigidbody2D rbFirePoint;
 

    void FixedUpdate()
    {

        Vector2 lookDir = rbPlayer.position - rbFirePoint.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg + 90f;
        rbFirePoint.MoveRotation(angle);
    }

}
