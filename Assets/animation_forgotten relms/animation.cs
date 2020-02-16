using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("dash"))
        {
            anim.SetBool("isDashing", true);
        }

        if (Input.GetButtonDown("dash1"))
        {
            anim.SetBool("isDashing", true);
        }

        if (Input.GetButtonUp("dash"))
        {
            anim.SetBool("isDashing", false);
        }

        if (Input.GetButtonUp("dash1"))
        {
            anim.SetBool("isDashing", false);
        }

        if (Input.GetButtonDown("Jump"))
        {
            anim.SetBool("isDashing", false);
        }
    }
}
