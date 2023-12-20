using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    [SerializeField]private int _seconds;
    void Start()
    {
        InvokeRepeating("DissappearOn", 0, _seconds);
    }
    void DissappearOn()
    {
        _seconds--;
        if (_seconds <= 0)
        {
            Destroy(gameObject);
        }
    }

}
