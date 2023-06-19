using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RunManager : MonoBehaviour
{
    SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
    public TMP_InputField inputField;

    public void GetSizeRun()
    {
        singlyLinkedList.GetSize();
    }

    public void PrintRun()
    {
        singlyLinkedList.Print();
    }

    public void AddNodeFrontRun()
    {
        int i = 4;
        singlyLinkedList.AddNodeFront(i);
        Debug.Log($"{i}값을 가진 노드 첫번째에 추가");
    }

    public void AddNodeAtRun()
    {
        int i = 1;
        int j = 3;
        singlyLinkedList.AddNodeAt(i,j);
        Debug.Log($"{i}번째 위치에 {j}값을 가진 노드 추가");

    }

    public void AddNodeLastRun()
    {
        int i = 9;
        singlyLinkedList.AddNodeLast(i);
        Debug.Log($"{i}값을 가진 노드 마지막에 추가");
    }

    public void DeletNodeFromIdxRun()
    {
        int i = 0;
        singlyLinkedList.DeletNodeFromIdx(i);
        Debug.Log($"{i}번째 노드를 삭제");

    }


}
