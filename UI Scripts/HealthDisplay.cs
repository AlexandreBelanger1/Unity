using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public Text healthText;
    public Player player;
    void Update()
    {
        healthText.text = "  HP: " + player.health + " / " + player.maxHealth;
    }
}
