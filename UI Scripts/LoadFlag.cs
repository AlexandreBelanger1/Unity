using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadFlag : MonoBehaviour
{
    public bool Flag;
    void start()
    {
        Flag = false;
    }
    void Update()
    {
        DontDestroyOnLoad(this);
    }

    public void EnableFlag()
    {
        Flag = true;
    }
}
