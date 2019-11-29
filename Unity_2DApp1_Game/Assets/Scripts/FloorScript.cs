using UnityEngine;
public class FloorScript : MonoBehaviour
{
    [Header("滾動速度")]
    [Range(0.1f,99f)]
    public static float floorScroll = 3f;  //滾動速度
    public Transform floorP;

    /// <summary>
    /// 地板滾動
    /// </summary>
    private void Mobile()
    {

    }

    private void Update()
    {
        floorP.Translate(-floorScroll * Time.deltaTime, 0, 0);
    }
}
