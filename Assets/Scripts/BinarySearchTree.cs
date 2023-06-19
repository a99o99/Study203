using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeBST
{
    public int data;
    public NodeBST left;
    public NodeBST right;

    public NodeBST(int data)
    {
        this.data = data;
        left = null;
        right = null;
    }
}

public class BinarySearchTree
{
    public NodeBST root;

    public void Add(int data)
    {
        NodeBST newNode = new NodeBST(data);

        if(root == null)
        {
            root = newNode;
            return;
        }
        
        NodeBST curNode = root;

        while(curNode != null)
        {
            //입력하려는 데이터가 존재하는 경우
            if(newNode.data == curNode.data)
            {
                Debug.Log("존재하는 데이터");
            }
            //루트의 왼쪽으로 보내기
            else if(newNode.data < curNode.data)
            {
                if(curNode.left == null)
                {
                    curNode.left = newNode;
                    break;
                }
                else
                {
                    curNode = curNode.left;
                }
            }
            //루트의 오른쪽으로 보내기
            else
            {
                if(curNode.right == null)
                {
                    curNode.right = newNode;
                    break;
                }
                else
                {
                    curNode = curNode.right;
                }
            }
        }
    }

    public bool Search(int data)
    {
        NodeBST curNode = root;
        while(curNode != null)
        {
            if(data == curNode.data)
            {
                return true;
            }
            else if(data < curNode.data)
            {
                curNode = curNode.left;
            }
            else
            {
                curNode = curNode.right;
            }
        }
        return false;
    }
    public void Remove(int data)
    {
        NodeBST curNode = root;
        NodeBST prev = null;

        //데이터 검색
        while(curNode != null)
        {
            if(data == curNode.data)
                break;
            else if(data < curNode.data)
            {
                prev = curNode;
                curNode = curNode.left;
            }
            else
            {
                prev = curNode;
                curNode = curNode.right;
            }
        }
        if(curNode == null)
        Debug.Log("존재하지 않는 데이터");
        
        //자식노드가 0개인 경우
        if(curNode.left == null && curNode.right == null)
        {
            if(prev.left == curNode)
            {
                prev.left = null;
            }
            else
            {
                prev.right = null;
            }
            curNode = null;
        }
        //자식노드가 1개인 경우
        else if(curNode.left == null || curNode.right == null)
        {
            NodeBST child = (curNode.left != null) ? curNode.left : curNode.right;
            if(prev.left == curNode)
            {
                prev.left = child;
            }
            else
            {
                prev.right = child;
            }
            curNode = null;
        }
        //자식노드가 2개인 경우(오른쪽 서브트리에서 가장 작은 노드(min) 검색)
        else
        {
            var min = curNode.right;
            var pre = curNode;

            while(min.left != null)
            {
                pre = min;
                min = min.left;
            }
            curNode.data = min.data; //삭제할 노드의 위치에 min값 대입
            
            //min노드의 오른쪽 노드 처리
            if(pre.left == min)
            {
                pre.left = min.right;
            }
            else
            {
                pre.right = min.right;
            }
        }
    }
}