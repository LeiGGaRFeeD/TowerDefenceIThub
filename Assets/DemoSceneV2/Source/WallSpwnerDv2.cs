using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpwnerDv2 : MonoBehaviour
{
    private int _ranNum;
    [SerializeField] private int _timer;
    private int _timeStart;
    [SerializeField] private GameObject _wall;
    [SerializeField] private GameObject[] _wallPosition;
    // Start is called before the first frame update
    void Start()
    {
        _timeStart = _timer;
        InvokeRepeating("TimeCount", 0, 1);
    }
    void Randomize()
    {
        _ranNum = Random.RandomRange(0, 3);
        Instantiate(_wall, _wallPosition[_ranNum].transform);
    }
    void TimeCount()
    {
        if (_timer <= 0)
        {
            Debug.Log("Time is over");

            Randomize();
        }
        _timer = _timer - 1;
    }
}
