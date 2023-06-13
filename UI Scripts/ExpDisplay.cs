using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpDisplay : MonoBehaviour
{
    public Text expText;
    public Player player;
    void Update()
    {
        expText.text = "  XP: " + player.experience + " / " + player.exp2Level;
    }
}
