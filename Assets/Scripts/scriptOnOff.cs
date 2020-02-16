using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptOnOff : MonoBehaviour
{

    private GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        Player player = Player.GetComponent<Player>();
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Player.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
