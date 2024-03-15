using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai2 : MonoBehaviour
{   
    private List<int> list = new List<int>() { 1, 2, 3, 4, 5, 4, 6, 8, 4, 9, 10 };

    void Start()
    {
        Bai2abc();
    }

    void Update()
    {       
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log(list[i]);
        }
    }

    public void Bai2abc()
    {
        List<int> tempList = new List<int>();

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] != 4)
            {
                tempList.Add(list[i]);
            }
        }

        list = tempList;
    }
}
