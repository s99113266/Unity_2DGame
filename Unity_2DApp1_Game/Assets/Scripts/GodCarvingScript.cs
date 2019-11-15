using UnityEngine;

public class GodCarvingScript : MonoBehaviour
{
    [Header("跳躍高度")]
    [Range(50,2000)]
    public int jumpHeight = 0;

    [Header("是否死亡")]
    public bool Died = false;

    /// <summary>
    /// 是否功過水管的狀態
    /// </summary>
    /// <param name="Through">是否通過水管，預設值是"否"</param>
    /// <returns>返回通過狀態</returns>
    private bool IsThrough(bool Through = false)
    {
        return Through;
    }

    /// <summary>
    /// 跳躍
    /// </summary>
    private void IsJump()
    {

    }

    /// <summary>
    /// 死亡狀態
    /// </summary>
    private void IsDied()
    {

    }

    private void Update()
    {
        
    }
}
