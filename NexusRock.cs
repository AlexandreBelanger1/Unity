using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NexusRock : MonoBehaviour
{
    public Transform player;
    private Vector3 distance2Player;
    public Player you;

    void Update()
    {
        distance2Player = transform.position - player.position;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (distance2Player[1] < 2 && distance2Player[0] < 2)
        {
            if (distance2Player[1] > -2 && distance2Player[0] > -2)
            {
                if (SceneManager.GetActiveScene().buildIndex == 2)
                {
                    you.SavePlayer();
                    SceneManager.LoadScene(1);
                }
                else
                {
                    you.SavePlayer();
                    SceneManager.LoadScene(2);
                }
            }
        }
    }
}
