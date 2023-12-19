using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void GoToLVLone()
    {
        SceneManager.LoadScene("LVL1");
    }
    public void GoToLVLtwo()
    {
        SceneManager.LoadScene("LVL2");
    }
    public void GoToLVLthree()
    {
        SceneManager.LoadScene("LVL3");
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void GoToTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
