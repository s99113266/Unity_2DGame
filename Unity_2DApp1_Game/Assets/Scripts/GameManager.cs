using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [Header("起始分數")]
    public int fraction = 0;

    [Header("最高紀錄")]
    public int Record;

    [Header("水管預製物件")]
    public GameObject Pipe;

    [Header("選單介面")]
    public GameObject EndGame;

    public Text fractionText, RecordText;

    /// <summary>
    /// 增加分數
    /// </summary>
    /// <param name="Add">所需增加的分數，預設為1分</param>
    public void AddFraction(int Add = 1)
    {
        fraction += Add;
        fractionText.text = "" + fraction;
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
    public void GameEnd()
    {
        EndGame.SetActive(true);
        CancelInvoke("PipeProduce");
        HighestRecord();

    }

    private void PipeProduce()
    {
        
        Instantiate(Pipe, new Vector3(Pipe.transform.position.x, Random.Range(-1.3f, 1.49f), 0), Quaternion.identity);
    }

    private void Start()
    {
        InvokeRepeating("PipeProduce", 0, 2.5f);
        
    }

    private void Update()
    {
        
    }



}
