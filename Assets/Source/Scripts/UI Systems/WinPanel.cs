using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPanel : MonoBehaviour
{
    [SerializeField] GameObject WinhPanel;

    public void Win()
    {
        WinhPanel.SetActive(true);
    }
}
