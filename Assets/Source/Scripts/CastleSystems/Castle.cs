using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Castle : MonoBehaviour
{
    public int Hp;
    public Slider HealthBar;
    public WinPanel _winPanel;
    void Start()
    {
        HealthBar.maxValue = Hp;
        HealthBar.value = Hp;
        _winPanel = GameObject.FindGameObjectWithTag("WinManager").GetComponent<WinPanel>();
    }


    void Update()
    {
        if (Hp <= 0)
        {
            Destroy(gameObject);
            _winPanel.Win();
        }
        HealthBar.value = Hp;
    }

    public void TakeDamage(int Damage)
    {
        Hp -= Damage;
    }
}
