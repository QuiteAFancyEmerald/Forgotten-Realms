
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilityUnlock : MonoBehaviour
{
    public bool dishonoredSpell;
    public bool slowDownTime;
    // Use this for initialization
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            if (dishonoredSpell)
            {
                GameObject.FindWithTag("Player").GetComponent<Dashanimation>().enabled = true;
                Destroy(gameObject);
            }
            if (slowDownTime)
            {
                GameObject.FindWithTag("Player").GetComponent<Dashanimation>().enabled = true;
                Destroy(gameObject);
            }
        }
    }
}