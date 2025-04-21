using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartControl : MonoBehaviour
{
    ObjSound _ObjSound;

    private void Awake()
    {
        _ObjSound = gameObject.GetComponent<ObjSound>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision != null && collision.gameObject.tag == "Player")
        {
            Debug.Log("Huart");
            collision.gameObject.GetComponent<Obj_Healt>().CollectHealt(new MyPlayer_Healt());
            _ObjSound.PlaySound(new Obj_SoundPlay());
            this.gameObject.SetActive(false);

        }
    }
}
