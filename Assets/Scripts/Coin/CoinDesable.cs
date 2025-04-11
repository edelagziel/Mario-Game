using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDesable : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        Coins_Triger.Coin_collision += DesroyCoin;
    }
    private void OnDisable()
    {
        Coins_Triger.Coin_collision -= DesroyCoin;
    }


    private void DesroyCoin()
    {
        gameObject.SetActive(false);
    }
}
