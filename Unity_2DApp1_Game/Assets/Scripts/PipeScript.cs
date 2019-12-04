using UnityEngine;
public class PipeScript : FloorScript
{
    private void OnBecameInvisible()
    {
        Destroy(gameObject, 3.5f);
    }
}
