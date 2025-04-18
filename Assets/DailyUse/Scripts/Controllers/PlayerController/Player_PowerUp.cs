using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_PowerUp : MonoBehaviour
{
    public void CollectPowerUp(IPowerUp powerUp)
    {
        powerUp.ApplyPowerUp(this.gameObject);
    }
}
