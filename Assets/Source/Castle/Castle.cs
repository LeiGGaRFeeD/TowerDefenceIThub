using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int __damageIn;

    private void Start()
    {
        if (PlayerPrefs.GetInt("_castleHealth") == null)
        {
            PlayerPrefs.SetInt("_castleHealth", 100);
        }
        _health = PlayerPrefs.GetInt("_castleHealth");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<MainDebug>() == true)
        {
            _health = _health - __damageIn;
        }
    }
}
