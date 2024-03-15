using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : UICanvas
{    
    public void PlayGame()
    {
        UIManager.Instance.OpenUI<PickTuong>();      
        CloseDirectly();
    }
}
