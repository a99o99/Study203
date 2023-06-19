using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriorityQueue 
{
    int[] heap;
    int size;

    public PriorityQueue(int data)
    {
        heap = new int[data];
        size = 0;
    }

    private void ResizeHeap()
    {
        int[] temp = new int[heap.Length * 2];
        for(int i = 0; i < heap.Length; i++)
        {
            temp[i] = heap[i];
        }
        heap = temp;
    }
    private void Swap(int[] arr, int i, int j)
    {
        int tmp = arr[i];
        arr[i] = arr[j];
        arr[j] = arr[i];
    }

    private void HeapifyUp(int idx)
    {
        int idxParent = (idx-1)/2;

        while(heap[idx] < heap[idxParent] && idx > 0)
        {
            Swap(heap, idx, idxParent);
            idx = idxParent;
            idxParent = (idx-1)/2;
        }
    }

    private void HeapifyDown(int idx)
    {
        int idxLeftChild = (idx*2) +1;
        int idxRightChild = (idx*2) +2;
        int idxMin = idx;

        if(heap[idxMin] > heap[idxLeftChild] && idxLeftChild < size)
        {
            idxMin = idxLeftChild;
        }
        if(heap[idxMin] > heap[idxRightChild] && idxRightChild < size)
        {
            idxMin = idxRightChild;
        }
        if(idx != idxMin)
        {
            Swap(heap, idx, idxMin);
            HeapifyDown(idxMin);
        }
    }
    private void Enqueue(int data)
    {
        if(size == heap.Length)
        {
            ResizeHeap();
        }
        heap[size] = data;
        HeapifyUp(size);
        size++;
    }

    private int Dequeue()
    {
        if(size == 0)
        {
            return -1;
        }
        int data = heap[0];
        heap[0] = heap[size-1];
        size--;
        HeapifyDown(0);
        return data;
    }
}
