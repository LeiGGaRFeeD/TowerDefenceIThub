using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRuner : MonoBehaviour
{
    public Castle castleGameObject;
    private Rigidbody2D physic;
    public Transform castle;

    public float speed;
    public int HP;
    public int damage;
    void Start()
    {
        physic = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (castle.position.x < transform.position.x)
        {
            physic.velocity = new Vector2(-speed, 0);
        }
        else if (castle.position.x > transform.position.x)
        {
            physic.velocity = new Vector2(speed, 0);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Castle")
        {
            castleGameObject.TakeDamage(damage);
        }
    }
}
