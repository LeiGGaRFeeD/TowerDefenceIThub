using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyD : MonoBehaviour
{
    [SerializeField] private int _time;
    [SerializeField]private int _damage;
    [SerializeField] private float _reoeatRate;
    [SerializeField] private int _moneyPlus;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<BaseD>())
        {
            InvokeRepeating("DestWhenEnd", 0, _time);
            InvokeRepeating("DeletingHealth", 0, _reoeatRate);
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
    // Update is called once per frame
    void Update()
    {
        
    }
}
