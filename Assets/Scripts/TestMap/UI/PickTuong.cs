using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PickTuong : UICanvas
{
    Vector3 tartget = Vector3.zero;
    Vector3 poitStart = new Vector3(0, 500, 0);
    private float time = 1f;
    private RectTransform rectTransform;
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }
    private void OnEnable()
    {
        MoveTarget();
    }
    public void MoveTarget()
    {
        Debug.Log("sbdsas");
        rectTransform.DOAnchorPos(new Vector2(0f, 0f), time).From(poitStart).SetEase(Ease.OutElastic);
        
    }
    public void VoGame()
    {
        UIManager.Instance.OpenUI<GamePlay>();      
        SoundManager.Instance.sound.Play();
        Close(1f);
    }
}
