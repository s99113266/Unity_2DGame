using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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

    [Header("分數")]
    public Text fractionText, RecordText;

    /// <summary>
    /// 增加分數
    /// </summary>
    /// <param name="Add">所需增加的分數，預設為1分</param>
    public void AddFraction(int Add = 1)
    {
        fraction += Add;
        fractionText.text = "" + fraction;
        HighestRecord();
        switch (fraction)
        {
            case 20:
                FloorScript.floorScroll = 3.5f;
                break;
            case 40:
                FloorScript.floorScroll = 4f;
                break;
        }
    }

    /// <summary>
    /// 最高分紀錄
    /// </summary>
    private void HighestRecord()
    {
        if (fraction > Record)
        {
            PlayerPrefs.SetInt("分數紀錄", fraction);
        }
    }

    /// <summary>
    /// 遊戲結束
    /// </summary>
    public void GameEnd()
    {
        EndGame.SetActive(true);
        CancelInvoke("PipeProduce");
    }

    private void PipeProduce()
    {
        
        Instantiate(Pipe, new Vector3(Pipe.transform.position.x, Random.Range(-1.3f, 1.49f), 0), Quaternion.identity);
    }


    /// <summary>
    /// 重新開始遊戲
    /// </summary>
    public void ResetGame()
    {
        print("1");
        SceneManager.LoadScene("遊戲場景");
    }

    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void ExitGame()
    {
        print("2");
        Application.Quit();
    }

    private void Start()
    {
        InvokeRepeating("PipeProduce", 0, 2.5f);
        Record = PlayerPrefs.GetInt("分數紀錄");
        RecordText.text = "" + Record;

    }

    private void Update()
    {
        
    }



}
