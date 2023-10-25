using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UID : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private Text _money;

    void Update()
    {
        _text.text = PlayerPrefs.GetInt("healthD").ToString();
        _money.text = PlayerPrefs.GetInt("moneyD").ToString();
    }
}
