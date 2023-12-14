using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Transform target;
    public float speed;
    void Update()
    {
        Move();
    }

    public void SetTarget(Transform unit)
    {
        target = unit;
    }

    private void Move()
    {
        if (target != null)
        {
            Vector2 dir = target.position - transform.position;
            transform.Translate(dir.normalized * Time.deltaTime * speed);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "UnitFlyerTengu" || collision.gameObject.tag == "UnitShooterHebi" || collision.gameObject.tag == "UnitRunerStormDragon")
        {
            Destroy(gameObject);
        }
    }
}
