using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAmmo : MonoBehaviour
{
    public void TakeAmmo(ICollectableAmmo ammo)
    {
        ammo.AddAmmo();
    }

    public void ReduseAmmo(IDecreaseAmmo ammo)
    {
        ammo.DecreseAmmo();
    }


}
