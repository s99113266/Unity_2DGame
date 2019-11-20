using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("起始分數")]
    public int fraction = 0;

    [Header("最高紀錄")]
    public int Record;

    [Header("水管預製物件")]
    public GameObject Pipe;
    
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

    private void PipeProduce()
    {
        
        Destroy(Instantiate(Pipe, new Vector3(Pipe.transform.position.x, Random.Range(-1.3f, 1.49f), 0), Quaternion.identity), 3.5f);
    }

    private void Start()
    {
        InvokeRepeating("PipeProduce", 0, 1.5f);
        
    }

    private void Update()
    {
        
    }



}
