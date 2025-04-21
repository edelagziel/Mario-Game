using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Door_Controler : MonoBehaviour
{
    public static event Action OnplayerWin;

    // ObjSound _ObjSound;
    private void Awake()
    {
        // _ObjSound = gameObject.GetComponent<ObjSound>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null && collision.gameObject.tag == "Player")
        {
            Debug.Log("Mario want To enter the Door ");
            if (collision.gameObject.GetComponent<Keys>().Get_Open_Status() == true)
            {
                Debug.Log("You Won");
                OnplayerWin?.Invoke();


            }
            //   _ObjSound.PlaySound(new Obj_SoundPlay());
            else
            {
                Debug.Log("You Dont have Key");
            }
        }
    }
    
}
