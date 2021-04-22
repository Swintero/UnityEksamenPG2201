using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class collisionHandler : MonoBehaviour
{

    public Vector3 respawnPosition;
    private void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "restartLevelPlane":
                ReloadLevel();
                break;

            case "checkpoint":
                RestartCheckpoint();
                break;

            case "goal":
                LoadNextLevel();
                break;

            case "loadLevel1":
                specificLevel1();
                break;

            case "loadLevel2":
                specificLevel2();
                break;

            case "loadLevel3":
                specificLevel3();
                break;

            case "menu":
                loadMenu();
                break;

        }
    }

    void ReloadLevel()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    void RestartCheckpoint()
    {
        this.transform.position = respawnPosition;
    }

    void specificLevel1()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(2);
    }

    void specificLevel2()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(3);
    }

    void specificLevel3()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(4);
    }
    void loadMenu() {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(0);
    }
}
