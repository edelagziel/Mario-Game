using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCoins_Triger : MonoBehaviour 
{
    ObjSound _ObjSound;
    private void Awake()
    {
        _ObjSound = gameObject.GetComponent<ObjSound>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("coins Enter");
        if (collision != null && collision.gameObject.tag == "Player")
        {
            Score_Manger.Instance.GoldCoinScore.IncreaseScore();
            _ObjSound.PlaySound(new Obj_SoundPlay());
            this.gameObject.SetActive(false);
        }
    }
    
}
