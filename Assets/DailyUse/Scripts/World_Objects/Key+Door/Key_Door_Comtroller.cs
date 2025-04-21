using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Door_Comtroller : MonoBehaviour
{
   // ObjSound _ObjSound;
    private void Awake()
    {
        // _ObjSound = gameObject.GetComponent<ObjSound>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Key Taken");
        if (collision != null && collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Keys>().Key_Open(new OpenDoor_1());
         //   _ObjSound.PlaySound(new Obj_SoundPlay());
            this.gameObject.SetActive(false);

        }
    }
}
