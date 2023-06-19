using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeC
{
    public int data;
    public NodeC next;
    
    public NodeC(int data)
    {
        this.data = data;
        next = null;
    }
}

public class CircularLikedList
{
    NodeC head;
    NodeC tail;

    public void CAddNodeLast(int data)
    {
        NodeC newNode = new NodeC(data);

        if(head == null)
        {
            head = newNode;
            newNode.next = head;
            tail = newNode;
            return;
        }
        tail.next = newNode;
        tail = newNode;
        tail.next = head;
    }

    public void CAddNodeFront(int data)
    {
        NodeC newNode = new NodeC(data);
        if(head == null)
        {
            head = newNode;
            newNode.next = head;
            tail = newNode;
            return;
        }
        tail.next = newNode;
        newNode.next = head;
        head = newNode;
    }

    public void CDeletNodeFromData(int data)
    {
        if(head == null)
        {
            Debug.Log("리스트가 비었습니다.");
        }
        if(head.data == data)
        {
            if(head.next == head)
            {
                head.next = null;
                head = null;
            }
            else
            {
                tail.next = head.next;
                head = head.next;
            }
        }
        else
        {
            NodeC target = head;
            while(target.next != head)
            {
                if(target.next.data == data)
                {
                    target.next = target.next.next;
                    return;
                }
            }
            if(target.next == tail)
            {
                tail = target;
            }
            target.next = target.next.next;

            Debug.Log("존재하지 않는 데이터");
            return;
        }
    }
}
