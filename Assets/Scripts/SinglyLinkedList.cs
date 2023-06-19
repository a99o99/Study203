using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public int data;
    public Node next;
    
    public Node(int data)
    {
        this.data = data;
        next = null;
    }
}

public class SinglyLinkedList
{
    public Node head;

//맨 앞에 노드 추가
    public void AddNodeFront(int data)
    {
        Node newNode = new Node(data);
        if(head == null)
        {
            head = newNode;
            return;
        }
        newNode.next = head;
        head = newNode;
    }
//맨 뒤에 노드 추가
    public void AddNodeLast(int data)
    {
        Node newNode = new Node(data);
        if(head == null)
        {
            head = newNode;
            return;
        }
        Node curNode = head;
        while(curNode.next != null)
        {
            curNode = curNode.next;
        }
        curNode.next = newNode;
    }
//특정위치에 노드 추가
    public void AddNodeAt(int index, int data)
    {
        if(index < 0)
        {
            Debug.Log("잘못된 위치");
            return;
        }
        if(index == 0)
        {
            AddNodeFront(data);
            return;
        }
        Node newNode = new Node(data);
        Node curNode = head;
        if(head == null && index > 0)
        {
            Debug.Log("잘못된 위치");
            return;
        }
        for(int i = 0; i < index-1 && curNode != null; i++)
        {
            curNode = curNode.next;
        }
        newNode.next = curNode.next;
        curNode.next = newNode;
    }
//위치값으로 데이터 찾기    
    public int FindDataFromIdx(int index)
    {
        Node getNode = GetNodeFromIdx(index);
        int data = getNode.data;
        Debug.Log($"{index}번째 노드가 가진 데이터 값 : {data}");
        return data;
    }
//데이터 값으로 위치 찾기
    public int FindIdxFromData(int data)
    {
        int index = 0;
        Node curNode = head;
        while(data != curNode.data && curNode != null)
        {
            curNode = curNode.next;
            index++;
        }
        if(data == curNode.data)
        {
            return index;
        }
        else
        {
            Debug.Log("존재하지 않는 데이터");
            return -1;
        }
    }
//위치값으로 노드 찾기
    public Node GetNodeFromIdx(int index)
    {
        Node getNode;
        Node curNode = head;

        if(index < 0 || index >= GetSize())
        {
            Debug.Log("잘못된 위치");
            return null;
        }
        for(int i = 0; i < index; i++)
        {
            curNode = curNode.next;
        }
        getNode = curNode;
        //Debug.Log($"{index}번째 노드를 찾았습니다.");
        return getNode;
    }
//데이터 값으로 노드 가져오기
    public Node GetNodeFromData(int data)
    {
        Node getNode;
        Node curNode = head;
        while(data != curNode.data && curNode != null)
        {
            curNode = curNode.next;
        }
        if(data == curNode.data)
        {
            getNode = curNode;
            return getNode;
        }
        else
        {
            Debug.Log("존재하지 않는 노드");
            return null;
        }
    }
//위치 값으로 노드 삭제하기
    public void DeletNodeFromIdx(int index)
    {
        Node target;            //삭제할 노드
        if(index < 0 || index >= GetSize())    //예외처리 index값이 -1 or List값보다 클 때
        {
            Debug.Log("잘못된 위치");
        }
        if(index == 0)                          //index값으로 0이 들어왔을 때
        {                                       //indext-1인 idx 를 쓰면 GetNode~(index)함수에서 예외처리 되므로
            target = GetNodeFromIdx(index);     //이 경우만 index 변수를 쓴다.
            head = target.next;
            target = null;
        }
        else
        {
            int idx = index - 1;        //target의 이전노드를 찾기 위한 변수
            Node prevNode = GetNodeFromIdx(idx);

            target = prevNode.next;                     
            prevNode.next = target.next;         //이전노드의 next값을 target.next로 바꿔줌
            target = null;                       //노드 삭제
        }
    }

    public void DeletNodeFromData(int data)
    {
        Node target = GetNodeFromData(data);
        
    }
//List 사이즈 가져오는 함수
    public int GetSize()    
    
    {
        int size = 0;
        Node curNode = head;
        if(head == null)
        {
            return size;
        }
        while(curNode != null)
        {
            size++;
            curNode = curNode.next;
        }
        return size;
    }
//작동 확인
    public void Print()
    {
        if(head == null)
        {
            Debug.Log("리스트가 비었습니다.");
        }
        else
        {
            int data;
            Node curNode = head;
            int size = GetSize();
            for(int i = 0; i < size; i++)
            {
                curNode = GetNodeFromIdx(i);
                data = curNode.data;
                Debug.Log($"{i}번째 노드, 데이터 : {curNode.data}");
            }
        }
    }
}
