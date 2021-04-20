using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool PausedGame = false;

    public GameObject pauseUI;

    // Update is called once per frame
    void Update()
    {
        //Game pause code
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PausedGame)
            {
                GameResume();
            }
            else
            {
                GamePause();
            }
        }

        //Stop camera
        //IKKE FUNKSJONELL, finner ikke scripted og objektet som brukes for kamera.
        /* if (pauseUI.gameObject.activeInHierarchy)
        {
            pauseUI.gameObject.SetActive(true);
            GameObject.FindGameObjectWithTag("FPSController").GetComponent<PlayerController>().enabled = false;
            GameObject.FindGameObjectWithTag("FPSController").GetComponent<SmoothPlayerCamera>().enabled = false;
        }
        else
        {
            pauseUI.gameObject.SetActive(false);
            GameObject.FindGameObjectWithTag("FPSController").GetComponent<PlayerController>().enabled = true;
            GameObject.FindGameObjectWithTag("FPSController").GetComponent<SmoothPlayerCamera>().enabled = true;
        } */

    }



    public void GameResume()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        PausedGame = false;
    }


    void GamePause()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        PausedGame = true;
    }

    public void GameExit()
    {
        Debug.Log("Exiting");
        SceneManager.LoadScene("MainMenu");
    }
}
