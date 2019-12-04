using UnityEngine;

public class GodCarvingScript : MonoBehaviour
{
    [Header("跳躍高度")]
    [Range(-50,-2000)]
    public int jumpHeight = -100;

    [Header("是否死亡")]
    public bool Died = false;

    public Rigidbody2D Rig2DGodCarvingScript;

    public GameObject goSraction, goGM;

    [Header("遊戲管理器")]
    public GameManager gm;


    [Header("音效來源")]
    public AudioSource aud;

    [Header("音效輸出")]
    public AudioClip AcJump, AcDied, AcOk;
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
    private void IsJump(int IsJumpInt = -150)
    {
        if (!Died)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                goSraction.SetActive(true);
                goGM.SetActive(true);
                aud.PlayOneShot(AcJump,15);
                Rig2DGodCarvingScript.Sleep();
                Rig2DGodCarvingScript.gravityScale = -1f;
                Rig2DGodCarvingScript.AddForce(new Vector2(0, IsJumpInt) * 1);


            }
            Rig2DGodCarvingScript.SetRotation(10 * Rig2DGodCarvingScript.velocity.y);
        }
        else
        {
            Rig2DGodCarvingScript.gravityScale = 1f;
        }
    }

    /// <summary>
    /// 死亡狀態
    /// </summary>
    private void IsDied()
    {
        Died = true;
        gm.GameEnd();
        FloorScript.floorScroll = 0;
        aud.PlayOneShot(AcDied, 15);
    }

    private void Start()
    {
        Screen.SetResolution(460,800,false);
    }

    private void Update()
    {
        IsJump(jumpHeight);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        IsDied();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name != "通過")
        {
            IsDied();
        }
        else
        {
            aud.PlayOneShot(AcOk, 15);
            gm.AddFraction();
        }
        
    }

}
