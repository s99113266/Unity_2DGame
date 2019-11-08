using UnityEngine;

public class GodCarvingScript : MonoBehaviour
{
    [Header("跳躍高度")]
    [Range(50,2000)]
    public int jumpHeight = 0;

    [Header("是否死亡")]
    public bool Died = false;
}
