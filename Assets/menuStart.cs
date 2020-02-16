using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //search for your first navigation button and select it

        GameObject.Find("start").GetComponent<Button>().Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
