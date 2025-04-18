using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsHandler : MonoBehaviour
{
    public fireballweapon Fireballweapon;
    public AxeWeapon AxeWeapon;

    public void Update()
    {
        ActiveWeapon();
    }

    private void ActiveWeapon()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl)&& Fireballweapon!=null)
        {
            Fireballweapon.shoot();
        }
        if(Input.GetKeyDown(KeyCode.RightControl)&& AxeWeapon!=null)
        {
            AxeWeapon.shoot();
        }
        if (Input.GetKeyDown(KeyCode.R) && AxeWeapon != null)
        {
            AxeWeapon.Relode();
        }

    }
}
