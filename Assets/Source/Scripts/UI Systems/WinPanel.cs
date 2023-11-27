using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPanel : MonoBehaviour
{
    [SerializeField] GameObject WinhPanel;
    Castle castle;

    void Start()
    {
        castle = GameObject.FindGameObjectWithTag("Castle").GetComponent<Castle>();
    }

    public void Update()
    {
        if (castle.Hp == 0)
        {
            WinhPanel.SetActive(true);
        }
        else
        {
            WinhPanel.SetActive(false);
        }
    }
}
