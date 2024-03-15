using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai3 : MonoBehaviour
{
   
    List<int> list = new List<int>() { 1, 3,4,6,7,4,4,6,};

  
    void Start()
    {
        TestBai3();
    }

   
    void Update()
    {
        
    }

    public void TestBai3()
    {
        List<int> curList = new List<int>();
        List<int> maxList = new List<int>();

        for (int i = 0; i < list.Count; i++)
        {
            if (i == 0 || list[i] > list[i - 1])
            {
                curList.Add(list[i]);
            }
            else
            {
                if (curList.Count > maxList.Count)
                {
                    maxList = new List<int>(curList);
                }
                curList.Clear();
                curList.Add(list[i]);
            }
        }

        if (curList.Count >= maxList.Count)
        {
            maxList = new List<int>(curList);
        }

        foreach (var num in maxList)
        {
            Debug.Log(num);
        }
    }
}
