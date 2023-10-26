using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRuner : MonoBehaviour
{
    public Transform castle;

    public float speed;
    public int HP;
    public int damage;


    private bool isCollidedWithCastle = false;
    private Castle castleObject;

    void Start()
    {
        castle = GameObject.FindGameObjectWithTag("Castle").GetComponent<Transform>();
        InvokeRepeating("DoDamage", Random.Range(0.0f, 1.0f), 1.0f);
    }


    void FixedUpdate()
    {
        if (castle!= null)
        {
            transform.position = Vector3.MoveTowards(transform.position, castle.position, speed * Time.fixedDeltaTime);
        }
        
    }

    private void DoDamage()
    {
        Debug.Log("DoDamage()");
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
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Castle")
        {
            isCollidedWithCastle = true;
            castleObject = collision.gameObject.GetComponent<Castle>();
        }
    }
}
