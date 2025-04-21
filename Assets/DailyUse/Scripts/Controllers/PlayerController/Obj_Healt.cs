using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Obj_Healt : MonoBehaviour
{
    public TextMeshProUGUI _HealtText;
    int Cur_Obj_Healt=0;
    public void Awake()
    {
        
    }
    
    public void ReastHealt(IHealthManager healthManager)
    {
        healthManager.ResatHelth(_HealtText,ref Cur_Obj_Healt);
        
    }
    public void CollectHealt(IHealthManager healthManager)
    {
        healthManager.AddHealth(_HealtText, ref Cur_Obj_Healt);
       // powerUp.ApplyPowerUp(this.gameObject);
    }
    public void RadusHealt(IHealthManager healthManager)
    {
        healthManager.RemoveHealth(_HealtText, ref Cur_Obj_Healt);
       
    }
    public int GetObjHelte()
    {
        return Cur_Obj_Healt;
    }

}
