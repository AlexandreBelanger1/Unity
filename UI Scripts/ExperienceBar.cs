using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExperienceBar : MonoBehaviour
{
    public Slider slider;
    public Player player;

    public void SetExperience()
    {
        slider.value = player.experience;
    }

    public void Setexp2Level()
    {
        slider.maxValue = player.exp2Level;
    }

}
