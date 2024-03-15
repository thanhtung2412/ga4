using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai1 : MonoBehaviour
{
    private int[] arr = new int[] { 1, 5, 3, 7, 6, 8, 4, 8, 1, 0 };
    public int minI =100;
    public int maxI = -1;
    private void Start()
    {
        MinBai1();
        MaxBai1();
    }
    private void Update()
    {
        
        Debug.Log("MinI LA:" +minI);
        Debug.Log("MaxI LA:" +maxI);
    }
    
    public int MinBai1()
    {
        for(int i= 0; i<arr.Length; i++)
        {
            if (arr[i] %2 == 1)
            {
                if (arr[i] <= minI)
                {
                    minI = arr[i];
                   
                }
            }
        }
        return minI;
    }
    public int MaxBai1()
    {
        for(int i= 0; i<arr.Length; i++)
        {
            if (arr[i] >= maxI)
            {
                maxI = arr[i];
                
            }
        }
        return maxI;
    }
}
