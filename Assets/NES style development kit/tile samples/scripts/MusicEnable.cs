using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicEnable: MonoBehaviour
{
    private AudioSource music;


    void Start()
    {
        music = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            music.enabled = true;
        }
    }
}