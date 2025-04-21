using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeController : MonoBehaviour
{
    ObjSound _ObjSound;
    private void Awake()
    {
        _ObjSound = gameObject.GetComponent<ObjSound>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Axe Taken");
        if (collision != null && collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerAmmo>().TakeAmmo(new AddAmmoAxe());
            _ObjSound.PlaySound(new Obj_SoundPlay());
            this.gameObject.SetActive(false);

        }
    }
}
