using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotate : MonoBehaviour
{
    private Move move;
    private void Start()
    {
        move = GetComponent<Move>();
    }
    private void Update()
    {
        
        if(move.dir.x < 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
        }
        else
        {
            transform.rotation = Quaternion.identity;
        }
    }
}
