using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private bool _debugIsOn;
    private void Update()
    {
        _text.text = PlayerPrefs.GetInt("_castleHealth").ToString();
        if (_debugIsOn == true)
        {
            Debug.Log("Healt = "+ PlayerPrefs.GetInt("_castleHealth"));
        }
    }
}
