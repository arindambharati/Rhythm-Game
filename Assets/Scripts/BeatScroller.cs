﻿using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    [SerializeField] private float beatTempo;
    [SerializeField] private bool hasStarted;


    void Start()
    {
        beatTempo = beatTempo / 60f;
    }


    void Update()
    {
        if (!hasStarted){
            if (Input.anyKeyDown)   hasStarted = true;
        }
        else{
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }
    }
}
