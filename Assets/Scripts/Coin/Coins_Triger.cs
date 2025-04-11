using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins_Triger : MonoBehaviour 
{
    public static event Action Coin_collision;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("coins Enter");
        if (collision != null && collision.gameObject.tag == "Player")
        {
            Coin_collision?.Invoke();
        }
    }
    
}
