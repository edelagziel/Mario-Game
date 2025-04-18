using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFlowerController : MonoBehaviour
{
    ObjSound _ObjSound;
    private void Awake()
    {
        _ObjSound = gameObject.GetComponent<ObjSound>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Flower Enter");
        if (collision != null && collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player_PowerUp>().CollectPowerUp(new FireFlowerPowerUp());
            _ObjSound.PlaySound(new Obj_SoundPlay());
            this.gameObject.SetActive(false);

        }
    }
}
