using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    private AudioSource myLight;


    void Start()
    {
        myLight = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.D))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}

