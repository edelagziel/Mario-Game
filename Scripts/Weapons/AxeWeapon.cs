using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeWeapon : MonoBehaviour, IWeapon
{
    public GameObject axe;
    public void Shoot()
    {
        if (axe != null)
        {
            GameObject curAxe = Instantiate(axe, transform.position, new Quaternion());
            ProjectileAxe scAxe = curAxe.GetComponent<ProjectileAxe>();
            if (scAxe != null)
            {
                float direction = 1;
                if (transform.parent != null)
                    direction = transform.parent.localScale.x;
                scAxe.Shoot(direction);
            }
        }
    }
}