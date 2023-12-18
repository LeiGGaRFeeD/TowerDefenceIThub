using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Sprites;
using UnityEngine;
using UnityEngine.UI;

public class UnitRuner : MonoBehaviour
{
    public Transform castle;

    public float speed;
    public int HP;
    public int damage;
    public Shooting shoot;
    public Slider HealthBar;


    private bool isCollidedWithCastle = false;
    private bool isCollidedWithTower = false;
    private bool isCollidedWithTowerKicker = false;

    private Castle castleObject;
    private TowerShooter towerObject;
    private TowerKicker kicker;

    void Start()
    {
        HealthBar.maxValue = HP;
        HealthBar.value = HP;
        castle = GameObject.FindGameObjectWithTag("Castle").GetComponent<Transform>();
        shoot = GameObject.FindGameObjectWithTag("Shooter").GetComponent<Shooting>();
        InvokeRepeating("DoDamage", Random.Range(0.0f, 1.0f), 1.0f);
    }

    void Update()
    {
        if (HP <= 0)
        {
            Destroy(gameObject);
        }
        HealthBar.value = HP;
    }

    void FixedUpdate()
    {
        if (castle != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, castle.position, speed * Time.fixedDeltaTime);
        }

    }

    private void DoDamage()
    {
        if (isCollidedWithCastle)
        {
            if (castleObject.Hp <= 0)
            {
                isCollidedWithCastle = false;
            }
            else
            {
                castleObject.TakeDamage(damage);
            }

        }

        if (isCollidedWithTower)
        {
            if (towerObject.Hp <= 0)
            {
                isCollidedWithTower = false;
            }
            else
            {
                towerObject.TakeDamage(damage);
            }

        }

        if (isCollidedWithTowerKicker)
        {
            if (kicker.Hp <= 0)
            {
                isCollidedWithCastle = false;
            }
            else
            {
                kicker.TakeDamage(damage);
                HP -= kicker.Damage;
            }

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Castle")
        {
            isCollidedWithCastle = true;
            castleObject = collision.gameObject.GetComponent<Castle>();
        }
        if (collision.gameObject.tag == "TowerShooter")
        {
            isCollidedWithTower = true;
            towerObject = collision.gameObject.GetComponent<TowerShooter>();
        }
        if (collision.gameObject.tag == "TowerKicker")
        {
            isCollidedWithTowerKicker = true;
            kicker = collision.gameObject.GetComponent<TowerKicker>();
        }
        if (collision.gameObject.tag == "Bullet")
        {
            HP -= shoot.damage;
        }
    }
}