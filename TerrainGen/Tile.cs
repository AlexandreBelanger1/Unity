using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public string type;
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;

    public Tile()
    {
        type = "Grass";
        //int index = getIndex(type);
       // spriteRenderer.sprite = sprites[0];
    }
    public string getType()
    {
        return type;
    }
    void importType(string type)
    {
        int index = getIndex(type);
        spriteRenderer.sprite = sprites[index];
    }
    int getIndex(string type)
    {
        if (type == "Grass")
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }
  
    
}
