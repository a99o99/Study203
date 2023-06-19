using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergySort : MonoBehaviour
{
    public int[] arr = new int[]{15,8,5,30,45,20};
    public static void Merge(int[] arr, int leftIdx, int midIdx, int rightIdx)
    {
        int n1 = midIdx - leftIdx + 1;
        int n2 = rightIdx - midIdx;

        int[] L = new int[n1];
        int[] R = new int[n2];

        for(int i = 0; i < n1; i++)
        {
            L[i] = arr[leftIdx + i];
        }
        for(int i = 0; i < n2; i++)
        {
            R[i] = arr[midIdx + 1 + i];
        }

        int k = leftIdx;
        int p = 0;
        int q = 0;

        while(p < n1 && q < n2)
        {
            if(L[p] <= R[q])
            {
                arr[k] = L[p];
                p++;
            }
            else
            {
                arr[k] = R[q];
                q++;
            }
            k++;
        }

        while(p < n1)
        {
            arr[k] = L[p];
            p++;
            k++;
        }
        while(q < n2)
        {
            arr[k] = R[q];
            q++;
            k++;
        }
    }
    public static void MergeSort(int[] arr, int leftIdx, int rightIdx)
    {

    }
}
