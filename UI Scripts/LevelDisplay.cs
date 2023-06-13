using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDisplay : MonoBehaviour
{
    public Text LevelText;
    public Player player;
    void Update()
    {
        LevelText.text = "" + player.level;
    }
}
