using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public float level;
    public float health;
    public float maxHealth;
    public float experience;
    public float exp2Level;
    // public float[] position;

    public PlayerData(Player player)
    {
        level = player.level;
        health = player.health;
        maxHealth = player.maxHealth;
        experience = player.experience;
        exp2Level = player.exp2Level;
        //position = new float[3];
        //position[0] = player.transform.position.x;
        //position[1] = player.transform.position.y;
        //position[2] = player.transform.position.z;
    }

}
