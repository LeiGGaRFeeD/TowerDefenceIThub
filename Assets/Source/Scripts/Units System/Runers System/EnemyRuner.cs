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
        castle = GameObject.FindGameObjectWithTag("Castle").GetComponent<Transform>();
    }


    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, castle.position, speed * Time.fixedDeltaTime);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Castle")
        {
            castleGameObject.TakeDamage(damage);
        }
    }
}
