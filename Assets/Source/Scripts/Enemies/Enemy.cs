using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health; //Здоровье
    [SerializeField] private int _score; //очков за уничтожение
    [SerializeField] private int _damageOut; //Наносит урон
    [SerializeField] private int _damageIn; //Поступаемый урон

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<MainDebug>() == true)
        {
            _health = _health - _damageIn;
            DebugVoid(collision);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<MainDebug>() == true)
        {
            PlayerPrefs.SetInt("_castleHealth", PlayerPrefs.GetInt("_castleHealth")-10);
        }
    }

    //Debug part
    [SerializeField] private bool _debugIsOn;
    void DebugVoid(Collision2D collision)
    {
        if (_debugIsOn == true)
        {
            Debug.Log("________");
            Debug.Log("Gameobject: " + gameObject);
            Debug.Log("Health: " + _health);
            Debug.Log("Damaged from: " + collision.gameObject);
            Debug.Log("Damaged score: "+ _damageIn);
        }
    }
}
