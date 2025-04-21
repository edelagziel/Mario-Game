using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReset : MonoBehaviour,Ireset
{
    Obj_Healt CurrentObjHelte;
    ResetPos ResetPos;
    Keys Keys;
    fireballweapon fireballweapon;



    private void Awake()
    {
        CurrentObjHelte = this.gameObject.GetComponent<Obj_Healt>();
        ResetPos= this.gameObject.GetComponent<ResetPos>();
        Keys=this.gameObject.GetComponent<Keys>();
        fireballweapon fireballweapon = this.gameObject.GetComponentInChildren<fireballweapon>(true);


    }
    public void ResetObject()
    {
        this.gameObject.SetActive(true);
        //if (CurrentObjHelte != null)
            CurrentObjHelte.ReastHealt(new MyPlayer_Healt());
       // if (ResetPos != null)
            ResetPos.ResetPosi();
       // if(Keys!=null)
        Keys.Key_Reset(new OpenDoor_1());
        AmmoManger.Instance.axeAmmo.ReastetAmmo();

        if (fireballweapon != null)
            fireballweapon.UnEquip();
    }
   

}
