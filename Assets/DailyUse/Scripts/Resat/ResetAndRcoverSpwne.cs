using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAndRcoverSpwne : MonoBehaviour,Ireset
{
    ResetPos ResetPos;
    public void Awake()
    {
        ResetPos=this.GetComponent<ResetPos>();
    }
    public void ResetObject()
    {
        this.gameObject.SetActive(true);
        ResetPos.ResetPosi();

    }


}
