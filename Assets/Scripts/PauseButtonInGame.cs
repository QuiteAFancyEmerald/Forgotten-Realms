using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButtonInGame : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;

    [SerializeField] private bool isPaused;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            ActivateMenu();
        }

        else
        {
            DeactivateMenu();
        }
    }

    void ActivateMenu()
    {
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
        AudioListener.pause = true; //For the Audio. Paused the audio.
    }

    public void DeactivateMenu()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false; //For the Audio. Might need to disble later.
        pauseMenuUI.SetActive(false);
        isPaused = false;
    }
}