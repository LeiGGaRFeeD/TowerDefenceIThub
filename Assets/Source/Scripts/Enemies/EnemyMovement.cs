using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _speed;
    [SerializeField] private float _didtanceY;
    [SerializeField] private float _didtanceX;
    void Start()
    {
        Movement();
    }
    void Movement()
    {
        Vector3 endPosition = new Vector3(gameObject.transform.position.x+_didtanceX, gameObject.transform.position.y + _didtanceY, 0);
        gameObject.transform.DOLocalMove(endPosition, _speed);
        InvokeRepeating("DelayForActivation", (_speed + 1), 0);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
