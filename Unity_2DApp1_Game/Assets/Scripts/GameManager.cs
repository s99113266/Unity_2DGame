using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("起始分數")]
    public int fraction = 0;

    [Header("最高紀錄")]
    public int Record;

    /// <summary>
    /// 增加分數
    /// </summary>
    /// <param name="Add">所需增加的分數，預設為1分</param>
    private void AddFraction(int Add = 1)
    {
        fraction += Add;
    }

    /// <summary>
    /// 最高分紀錄
    /// </summary>
    private void HighestRecord()
    {
        if (fraction > Record) Record = fraction;
    }

    /// <summary>
    /// 遊戲結束
    /// </summary>
    private void GameEnd()
    {

    }

}
