using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : Singleton<LevelManager> 
{ 
    
    void Start()
    {
        UIManager.Instance.OpenUI<MainMenu>();
    }

    
}
