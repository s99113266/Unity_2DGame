﻿using UnityEngine;

public class FloorScript : MonoBehaviour
{
    [Header("滾動速度")]
    [Range(0.1f,99f)]
    public float floorScroll = 0.5f;  //滾動速度
    public Transform floorP;
    
    private void Update()
    {
        floorP.Translate(-floorScroll, 0, 0);
    }
}
