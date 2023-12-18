using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LimitClicks : MonoBehaviour
{
    [SerializeField]private int _taps = 2;
    private int _time = 4;

    private int _tapsR;
    private int _timeR;

    [SerializeField] private GameObject[] _buttons;

    private void Start()
    {
        _tapsR = _taps;
        _timeR = _time;
    }

    public void ButtonCount()
    {
        _taps = _taps - 1;
        Debug.Log("Taps: " + _taps);
        if (_taps <= 0)
        {
            Debug.Log("taps zero or below zero ");
          //  gameObject.SetActive(false);
          for (int i = 0; i<_buttons.Length; i++)
            {
                _buttons[i].SetActive(false);
            }
            InvokeRepeating("Timer", 0, 1);
        }
    }
    private void Timer()
    {
        Debug.Log("Time is: " + _time);
        _time = _time - 1;
        if (_time <= 0)
        {
            CancelInvoke();
            // gameObject.SetActive(true);
            for (int i = 0; i < _buttons.Length; i++)
            {
                _buttons[i].SetActive(true);
            }
            _taps = _tapsR;
            _time = _timeR;
        }
    }

}
