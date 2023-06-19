using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QickSort : MonoBehaviour
{
    public int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right];
        int i = left -1;
        for(int j = left; j <= right-1 ; j++)
        {
            if(arr[j] <= pivot)
            {
                i++;
                Swap(arr,i,j);
            }
        }
        Swap(arr, i+1, right);
        return i+1;
    }
    public int PartitionWhile(int[] arr, int left, int right)
    {
        int pivot = arr[right];
        int l = left;
        int r = right-1;

        while(l <= r)
        {
            while(arr[l] < pivot)
            {
                l++;
            }
            while(arr[r] < pivot)
            {
                r++;
            }
            if(l <= r )
            {
                Swap(arr, l, r);
            }
        }

        return l;
    }

    void Swap(int[] arr, int a, int b)
    {
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }

    void QuickSort1(int[] arr, int left, int right)
    {
        int p = Partition(arr, left, right);

        if(left < right)
        {
            QuickSort1(arr, left, p-1);
            QuickSort1(arr, p+1, right);
        }
    }
}

