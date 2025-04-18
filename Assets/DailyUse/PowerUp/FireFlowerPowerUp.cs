using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FireFlowerPowerUp : IPowerUp
{
    public void ApplyPowerUp(GameObject Object)
    {
        if (Object != null)
        {
            fireballweapon fireballweapon = Object.gameObject.GetComponentInChildren<fireballweapon>();
            if (fireballweapon != null)
            {
                fireballweapon.Equip();
            }
        }
    }
}
