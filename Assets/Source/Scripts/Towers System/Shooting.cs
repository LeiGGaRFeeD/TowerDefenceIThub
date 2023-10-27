using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float range;
    public int damage;
    private float CurrCooldown;
    public float Cooldown;

    [SerializeField] GameObject Projectile;
    private void Update()
    {
        if (CanShoot())
        {
            SearchTarget();
        }

        if(CurrCooldown > 0)
        {
            CurrCooldown -= Time.deltaTime;
        }
    }

    bool CanShoot()
    {
        if (CurrCooldown <= 0) 
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void SearchTarget()
    {
        Transform nearestUnit = null;
        float nearestUnitDistance = Mathf.Infinity;

        foreach(GameObject unit in GameObject.FindGameObjectsWithTag("Unit"))
        {
            float currDistance = Vector2.Distance(transform.position, unit.transform.position);

            if((currDistance < nearestUnitDistance) && (currDistance <= range))
            {
                nearestUnit = unit.transform;
                nearestUnitDistance = currDistance;
            }
        }

        if (nearestUnit != null)
        {
            Shoot(nearestUnit);
        }
    }

    void Shoot(Transform Unit)
    {
        CurrCooldown = Cooldown;
        GameObject proj = Instantiate(Projectile);
        proj.transform.position = transform.position;
        proj.GetComponent<Bullet>().SetTarget(Unit);
    }
}
