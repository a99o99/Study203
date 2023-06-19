using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeD
{
    public int data;
    public NodeD prev;
    public NodeD next;
    
    public NodeD(int data)
    {
        this.data = data;
        prev = null;
        next = null;
    }
}

public class DoublyLinkedList
{
    public NodeD head;
    public NodeD tail;

    public void DAddNodeFront(int data)
    {
        if(data < 0)
        {
            Debug.Log("잘못된 위치");
        }
        NodeD newNode = new NodeD(data);
        if(head == null)
        {
            head = newNode;
            tail = newNode;
            return;
        }
        head.prev = newNode;
        newNode.next = head;
        head = newNode;
    }

    public void DAddNodeLast(int data)
    {
        NodeD newNode = new NodeD(data);
        if(head == null)
        {
            head = newNode;
            tail = newNode;
            return;
        }
        tail.next = newNode;
        newNode.prev = tail;
        tail = newNode;
    }

    public void DDeletNodeFromData(int data)
    {
        if(head == null)
        {
            Debug.Log("리스트가 비었습니다.");
            return;
        }
        NodeD target = head;
        //data를 처음으로 찾았을때 예외
        if(head.data == data)
        {
            head = head.next;
            head.prev = null;
            return;
        }
        while(target.data != data && target != null)
        {   
            target =  target.next;
        }
        if(target == null && target.data != data)
        {
            Debug.Log("존재하지 않는 데이터");
        }
        if(target.next == null)
        {
            target.prev.next = null;
        }
        else
        {
            target.prev.next = target.next;
            target.next.prev = target.prev;
        }
    }
}
