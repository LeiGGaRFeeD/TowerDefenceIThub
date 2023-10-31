using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWallD : MonoBehaviour
{
    [SerializeField] private GameObject _tower;
    [SerializeField] private GameObject[] _towerPlace;
    private int _num;

    public void Spawn()
    {
        _num = PlayerPrefs.GetInt("_towerPlace");
        Instantiate(_tower, _towerPlace[_num].transform);
    }
}
