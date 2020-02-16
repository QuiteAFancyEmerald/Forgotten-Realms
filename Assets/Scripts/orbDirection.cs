using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbDirection : MonoBehaviour
{

    public bool up;
    public bool down;
    public bool forward;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("cursorY"))
        {
            anim.SetBool("forward", true);
            anim.SetBool("up", false);
            anim.SetBool("down", false);
        }

        if (Input.GetButtonUp("cursorY2"))
        {
            anim.SetBool("forward", true);
            anim.SetBool("down", false);
            anim.SetBool("up", false);
        }

        if (Input.GetButtonDown("cursorY"))
        {
            anim.SetBool("up", true);
            anim.SetBool("forward", false);
            anim.SetBool("down", false);
        }

        if (Input.GetButtonDown("cursorY2"))
        {
            anim.SetBool("down", true);
            anim.SetBool("forward", false);
            anim.SetBool("up", false);
        }
    }
}
