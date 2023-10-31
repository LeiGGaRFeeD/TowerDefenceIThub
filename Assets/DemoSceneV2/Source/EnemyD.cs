using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyD : MonoBehaviour
{
    [SerializeField] private int _time;
    [SerializeField]private int _damage;
    [SerializeField] private float _reoeatRate;
    [SerializeField] private int _moneyPlus;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<BaseD>() == true )
        {
            InvokeRepeating("DestWhenEnd", 0, _time);
            InvokeRepeating("DeletingHealth", 0, _reoeatRate);
        }
        if (collision.GetComponent<WallD>() == true)
        {

        }
    }
    void DestWhenEnd()
    {
        _time = _time - 1;

        if (_time <= 0)
        {
            Destroy(gameObject);
        }
    }
    void DeletingHealth()
    {
        PlayerPrefs.SetInt("healthD", PlayerPrefs.GetInt("healthD") - _damage);
        PlayerPrefs.SetInt("moneyD", PlayerPrefs.GetInt("moneyD") + _moneyPlus);
    }

}
