using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerShooter : MonoBehaviour
{
    public int Hp;
    public Slider HealthBar;
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
        Hp = Hp - Damage;
    }
}
