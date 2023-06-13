using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public bool LoadFlag;
    public float level = 1;
    public float experience = 0;
    public float exp2Level = 200;
    public float health = 100;
    public float maxHealth;
    public HealthBar healthBar;
    public ExperienceBar experienceBar;
    public Tile heldTile;
    public bool ShootActive;
    public bool InteractActive;
    public bool TileSelected;

    void Start()
    {
        InteractActive = false;
        ShootActive = true;
        TileSelected = false;
        LoadPlayer();
        //if (SceneManager.GetActiveScene().name == "GameExplore")
        //{
        //    maxhealth = 200;
        //    health = maxhealth;
        //}
        PlayerUISetup();
    }
    void Update()
    {
        PlayerStatusUpdate();
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        level = data.level;
        experience = data.experience;
        exp2Level = data.exp2Level;
        health = data.health;
        maxHealth = data.maxHealth;

        //Vector3 position;
        //position.x = data.position[0];
        //position.y = data.position[1];
        //position.z = data.position[2];
        //transform.position = position;
    }
    public void PlayerUISetup()
    {
        if (SceneManager.GetActiveScene().name == "GameBase")
        {
            maxHealth = 200;
            health = maxHealth;
        }
        healthBar.SetMaxHealth(maxHealth);

    }
    public void PlayerStatusUpdate()
    {
        healthBar.SetHealth(health);
        experienceBar.SetExperience();


        if (health <= 0)
        {
            SceneManager.LoadScene(3);
        }
        if (experience >= exp2Level)
        {
            LevelUp();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
           experience += 25;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            health-= 25;
        }
    }
    public void LevelUp()
    {
        level++;
        experience = experience % exp2Level;
        exp2Level += 25;
        experienceBar.Setexp2Level();
        experienceBar.SetExperience();
    }
   public void ShootEnable()
    {
            ShootActive = true;
            InteractActive = false;
        TileSelected = false;
    }

    public void ShootDisable()
    {
            ShootActive = false;
            InteractActive = true;
        TileSelected = false;
    }
    public void Select1Slot()
    {
        TileSelected = true;
        ShootActive = false;
        InteractActive = false;
    }

}
