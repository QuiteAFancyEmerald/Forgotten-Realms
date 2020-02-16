using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doubledashing : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Awake()
    {
        anim.SetBool("isDashingDouble", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetBool("isDashingDouble", true);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("isDashingDouble", false);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetBool("isDashingDouble", true);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("isDashingDouble", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("isDashingDouble", false);
        }
    }
}
