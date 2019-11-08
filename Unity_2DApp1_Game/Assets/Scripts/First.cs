using UnityEngine;

public class First : MonoBehaviour
{
    [Header("金幣")]  //欄位說明
    [Range(0,99999)]  //數值欄位範圍
    public int Coin = 1200;  //金錢




    [Header("行走速度")]
    [Range(0.5f, 9.5f)]
    public float Speed = 0.5f; //行走速度

    [Header("物品名稱")]
    public string Article = ""; //物品

    [Header("是否通關")]
    public bool Victory = false;  //是否通關

    //會在特定的時間點已指定的次數執行
    //大多在腳本或是遊戲一開始時執行一次
    private void Start()
    {
        print("你好，世界!");
    }

    private void Update()
    {
    }
}