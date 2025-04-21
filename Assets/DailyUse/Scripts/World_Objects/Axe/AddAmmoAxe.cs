using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddAmmoAxe : MonoBehaviour, ICollectableAmmo
{
    void ICollectableAmmo.AddAmmo()
    {
        AmmoManger.Instance.axeAmmo.AddAmmo();
    }

    
}
