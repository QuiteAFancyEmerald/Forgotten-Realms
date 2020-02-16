using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderFight : MonoBehaviour
{
    private Animator anim; 

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    //PUT ON A PARENT
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            anim.SetBool("StartFight", true);
            Debug.Log("start fight");
        }
    }
}
