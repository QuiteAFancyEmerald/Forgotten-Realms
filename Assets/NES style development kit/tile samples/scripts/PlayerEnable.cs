using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnable : MonoBehaviour
{
    public GameObject player;
    private float Timer;
    public float TimeSpawn = 1f;
    private void Start()
    {
        Timer = TimeSpawn;

    }
    private void Update()
    {
        Timer -= Time.deltaTime;
        //player = GameObject.Find("Player");
        //Debug.Log(Timer);
        //Player playerScript = player.GetComponent<Player>();
        if (Timer <= 0)
        {
            GameObject.Find("GameObject").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            //if (playerScript.enabled == false) 
            //{
            //    playerScript.enabled = true;
            //}
        }
    }
}

