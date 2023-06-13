using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilePatch : MonoBehaviour
{
    private ArrayList tileList; 
    void start()
    {
        tileList = new ArrayList();
        for (int i = 0; i < 9; i++)
        {
            tileList.Add(new Tile());
        }
    }
}
