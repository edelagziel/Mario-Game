using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonEnemy : BaseEnamy,Ireset
{
    [SerializeField] private float _SpeedDitsance_BetwineFierrBall = 2f;
    fireballweapon DragowWeapone;
    private void Awake()
    {
        base.Awake();
        EnemyHelt.ReastHealt(new RedEnamyHelt());
    }
    private void Start()
    {
        DragowWeapone = gameObject.GetComponentInChildren<fireballweapon>();
        if (DragowWeapone != null)
        {
            DragowWeapone.Equip();
            StartCoroutine(AttackRate(_SpeedDitsance_BetwineFierrBall));
        }
    }
    private void FixedUpdate()
    {
    }
    public override void Attack()
    {
        if(DragowWeapone!=null)
        {
            DragowWeapone.shoot();
        }
        Debug.Log("attack");
        
    }

   

    public override void TakeDamge()
    {
        EnemyHelt.RadusHealt(new RedEnamyHelt());
        if (EnemyHelt.GetObjHelte() <= 0)
        {
            this.gameObject.SetActive(false);
        }

    }
    IEnumerator AttackRate(float Speed_Distance)
    {
        while (true)
        {
            Attack();
            yield return new WaitForSeconds(Speed_Distance);
        }

    }

    public void ResetObject()
    {
        base.Awake();
        DragowWeapone = gameObject.GetComponentInChildren<fireballweapon>();
        EnemyHelt.ReastHealt(new RedEnamyHelt());
        DragowWeapone.Equip();
        StartCoroutine(AttackRate(_SpeedDitsance_BetwineFierrBall));
    }

    public override void Reset()
    {
    }
}
