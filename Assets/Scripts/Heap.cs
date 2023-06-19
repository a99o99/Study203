using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heap
{
    List<int> heap = new List<int>();

    public int GetRootNode()
    {
        return 0;
    }
    public int GetLastNodeIdx()
    {
        return heap.Count -1;
    }
    public int GetLeftChildIdx(int idx)
    {
        return(idx * 2) + 1;
    }
    public int GetRightChildIdx(int idx)
    {
        return(idx * 2) + 2;
    }
    public int GetParentIdx(int idx)
    {
        return(idx -1 )/2;
    }
    public void InsertNode(int data)
    {
        heap.Add(data);
        int lastNode = GetLastNodeIdx();
        int parentIdx = GetParentIdx(lastNode);
        
    }
}
