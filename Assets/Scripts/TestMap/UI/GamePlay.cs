using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : UICanvas
{
    public void OutBtn()
    {
        UIManager.Instance.OpenUI<MainMenu>();
        SoundManager.Instance.sound.Play();
        Close(1f);
    }
}
