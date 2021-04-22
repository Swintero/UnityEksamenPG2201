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


    

}
