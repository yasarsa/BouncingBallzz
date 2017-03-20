using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour {
    public int level;

    public void loadScene(int level)
    {
        Application.LoadLevel(level);
    }

}
