using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private bool WebGLversion;
    [SerializeField] private GameObject quitButton;
    [SerializeField] private Text versionText;
    private void Start()
    {
        if (WebGLversion == true)
        {
            quitButton.SetActive(false);
            versionText.text = "WebGL Build version";
        }
        else
        {
            versionText.text = "InDev Build version";
        }
    }
    public void GoToLevelSelect()
    {
        Debug.Log("Loading Level Select scene");
        SceneManager.LoadScene("LevelSelect");
    }
    public void GoToAuthors()
    {
        Debug.Log("Loading Level Authors Scene");
        SceneManager.LoadScene("Authores");
    }
    public void GoToSettings()
    {
        Debug.Log("Loading Level settings Scene");
        SceneManager.LoadScene("Settings");
    }
    public void QuitFromApp()
    {
        Application.Quit();
    }
}
