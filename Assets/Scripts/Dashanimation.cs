using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dashanimation : MonoBehaviour
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
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetBool("isDashing", true);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("isDashing", false);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetBool("isDashing", true);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("isDashing", false);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("isDashing", false);
        }
    }
}
