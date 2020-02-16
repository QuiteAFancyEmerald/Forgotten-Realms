using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePlayer : MonoBehaviour
{
    private Animator anim;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (anim.GetBool("ShortAttack"))
            {
                anim.SetBool("ShortAttack", false);
            }
            else
            {
                anim.SetBool("ShortAttack", true);
            }
        }
    }
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("ShortAttack", false);
        anim.SetBool("Phase2", false);
        anim.SetBool("EndFight", false);
    }
}
