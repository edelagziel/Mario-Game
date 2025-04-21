using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract  class BaseEnamy : MonoBehaviour, IEnamy
{
   protected Obj_Healt EnemyHelt;
    protected virtual void Awake()
    {
        EnemyHelt = GetComponent<Obj_Healt>();
    }
    public abstract void Attack();
    public abstract void TakeDamge();
    public abstract void Reset();


}
