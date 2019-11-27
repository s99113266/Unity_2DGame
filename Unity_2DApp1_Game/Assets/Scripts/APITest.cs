using UnityEngine;

public class APITest : MonoBehaviour
{
    // Start is called before the first frame update
    public GodCarvingScript _GodCarvingScript;

    void Start()
    {
        _GodCarvingScript.jumpHeight = 999;
        //print(_GodCarvingScript.jumpHeight);
    }
}
