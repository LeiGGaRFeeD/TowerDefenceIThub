using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    public void RestartActiveLevel()
    {
        Debug.Log("Level restarting");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
