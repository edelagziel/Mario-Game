using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballWeapon : MonoBehaviour, IWeapon
{
    public GameObject fireball;

    public void Shoot()
    {
        if(fireball != null)
        {
            GameObject curFireball = Instantiate(fireball,transform.position,new Quaternion());
            ProjectileFireball scFireball = curFireball.GetComponent<ProjectileFireball>();
            if (scFireball != null)
            {
                float direction = 1;
                if (transform.parent != null)
                    direction = transform.parent.localScale.x;
                scFireball.Shoot(direction);
            }
        }
    }
}