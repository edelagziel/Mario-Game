using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabeEnemy : BaseEnamy
{
    [SerializeField]private int _maxMovement = 5;
    private int _direction = 1;
    [SerializeField]private float _Speed=2f;
    private Vector3 _startPosition;
    private void Awake()
    {
         _startPosition = transform.position;    
         base.Awake();
         EnemyHelt.ReastHealt(new RedEnamyHelt());

    }
    public override void Attack()
    {
        float distanceFromStart = transform.position.x - _startPosition.x;

        if (Mathf.Abs(distanceFromStart) >= _maxMovement)
        {
            _direction *= -1;
        }

        transform.position += new Vector3(_direction * _Speed * Time.deltaTime, 0f, 0f);
    }

    public override void Reset()
    {
        Debug.Log("Reset");
    }

    public override void TakeDamge()
    {
        EnemyHelt.RadusHealt(new RedEnamyHelt());
        if (EnemyHelt.GetObjHelte()<=0)
        {
            this.gameObject.SetActive(false);
        }

    }
    private void FixedUpdate()
    {
        Attack();
    }
}
