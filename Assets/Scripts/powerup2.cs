using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup2 : MonoBehaviour
{

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("powerUP2"))
        {
            Pickup();
        }
    }

    void Pickup()
    {
        gameObject.GetComponent<Dashanimation>().enabled = false;
        gameObject.GetComponent<doubledashing>().enabled = true;
    }

    
  
}

