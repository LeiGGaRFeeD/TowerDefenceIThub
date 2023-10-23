using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Castle : MonoBehaviour
{
    [SerializeField] int Hp;
    public Slider HealthBar;
    void Start()
    {
        HealthBar.value = Hp;
    }

    // Update is called once per frame
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
        Debug.Log("1'mh3r3");
    }
}
