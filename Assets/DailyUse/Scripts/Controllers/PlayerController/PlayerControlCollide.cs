using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class PlayerControlCollide : MonoBehaviour, IInvincible,Ireset
{
    public static event Action OnPlayerDied;
    ObjSound _ObjSound;
    bool IsInvincible=false;
    float TimeInvincibl = 1f;
    Obj_Healt CurrentObjHelte;
    
    private void Awake()
    {
        _ObjSound = gameObject.GetComponent<ObjSound>();
        CurrentObjHelte = this.gameObject.GetComponent<Obj_Healt>();
        CurrentObjHelte.ReastHealt(new MyPlayer_Healt());
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null && collision.gameObject.tag == "Kill"&& !IsInvincible)
        {
            CurrentObjHelte.RadusHealt(new MyPlayer_Healt());
            ActivateInvincibility(TimeInvincibl);
            this.gameObject.GetComponent<ResetPos>().ResetPosi();
            if(CurrentObjHelte.GetObjHelte()<=0)
            {
                //Event GameOver Player Lose
                OnPlayerDied?.Invoke();  
                this.gameObject.SetActive(false);
            }


            // _ObjSound.PlaySound(new Obj_SoundPlay());

            //this.gameObject.SetActive(false);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null && collision.gameObject.tag == "Kill" && !IsInvincible)
        {
            CurrentObjHelte.RadusHealt(new MyPlayer_Healt());
            ActivateInvincibility(TimeInvincibl);
            this.gameObject.GetComponent<ResetPos>().ResetPosi();
            if (CurrentObjHelte.GetObjHelte() <= 0)
            {
                //Event GameOver Player Lose
                OnPlayerDied?.Invoke();
                this.gameObject.SetActive(false);
            }


            // _ObjSound.PlaySound(new Obj_SoundPlay());

            //this.gameObject.SetActive(false);
        }
    }

    public void ActivateInvincibility(float duration)
    {
        IsInvincible=true;
        StartCoroutine(Invincib_time(duration));
    }
    IEnumerator Invincib_time(float duration)
    {
        yield return new WaitForSeconds(duration);
        IsInvincible=false;
    }

    public void ResetObject()
    {
        IsInvincible = false;

    }
}
