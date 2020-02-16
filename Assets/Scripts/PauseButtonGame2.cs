using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButtonGame2 : MonoBehaviour
{

    public static bool GameIsPaused = false; //Bool statements that checks to see if the game is paused.

    public GameObject pauseMenuUI;


    // Start is called before the first frame update
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }
    

    // Update is called once per frame
    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
