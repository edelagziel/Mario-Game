using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballweapon : MonoBehaviour, IUseableWeapon,Ireset
{
    public GameObject fireball;
    private bool _IsEquip=false;

    public void shoot()
    {
        if ( fireball != null && _IsEquip)
        {
            GameObject curFireball=Instantiate(fireball,transform.position,new Quaternion());
            projectiles_Fireaball ScFireaball = curFireball.GetComponent<projectiles_Fireaball>();
            if ( ScFireaball != null ) 
            {
                float Diraction = 1;
                if (transform.parent != null)
                    Diraction = transform.parent.localScale.x;
                    ScFireaball.Soot(Diraction);
            }
        }
    }
    public void Equip()
    {
        _IsEquip=true;
    }
    public void UnEquip()
    {
        _IsEquip = false;
    }

    public void ResetObject()
    {
        _IsEquip = false;

    }
}
