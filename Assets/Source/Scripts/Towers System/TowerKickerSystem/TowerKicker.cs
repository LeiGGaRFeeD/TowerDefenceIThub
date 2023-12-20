using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Sprites;
using UnityEngine;
using UnityEngine.UI;

public class TowerKicker : MonoBehaviour
{
    public int Hp;
    public Slider HealthBar;
    public int Damage;
    void Start()
    {
        HealthBar.maxValue = Hp;
        HealthBar.value = Hp;
    }


    void Update()
    {
        if (Hp <= 0)
        {
            Destroy(gameObject);
        }
        HealthBar.value = Hp;
    }

    public void TakeDamage(int Damage)
    {
        Hp -= Damage;
    }

}
