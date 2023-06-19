using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomInt : MonoBehaviour
{
    int[] arr = new int[]{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
    int[] arrLotto;

    public List<int> GetRandomList(int[] arr, int cnt)
    {
        if(cnt < 0 || cnt > arr.Length)
        {
            Debug.Log("잘못된 숫자 입력");
        }
        List<int> idxs = new List<int>();           //idx를 담아줄 List 생성
        for(int i = 0; i < cnt; i++)
        {
            int idx = Random.Range(0,arr.Length);   
            while(idxs.Contains(idx))
            {
                Debug.Log("중복");
                idx = Random.Range(0,arr.Length);
            }
            idxs.Add(idx);
        }
        return idxs;
    }

    public void Print(int[] arr, int cnt)
    {
        List<int> idxs = GetRandomList(arr, cnt);
        for(int i = 0; i < cnt; i++)
        {
            Debug.Log(arr[idxs[i]]);
        }
    }
    public void CreateLottoArr()
    {
        arrLotto = new int[45];
        for(int i = 0; i < 45; i++)
        {
            arrLotto[i] = i+1;
        }
    }

    private void Start() 
    {
        CreateLottoArr();
        Print(arrLotto, 6);
    }


}
