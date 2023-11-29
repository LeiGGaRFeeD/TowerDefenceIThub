using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SoulsScore : MonoBehaviour
{
    public TMP_Text ScoreText;
    public MoneySouls _souls;
    void Update()
    {
        ScoreText.text = "Souls: " + _souls.Souls;
    }
}
