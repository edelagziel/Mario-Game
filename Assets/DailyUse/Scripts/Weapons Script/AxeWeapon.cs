using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeWeapon : MonoBehaviour,IWeaponReload
{
    // Start is called before the first frame update
    public GameObject AxeWeapons;
    private bool _loaded=false;



    public void Awake()
    {
        
    }
    public void shoot()
    {
        if (AxeWeapons != null&& _loaded==true&& AmmoManger.Instance.axeAmmo.HasAmmo())
        {
            GameObject curAxe = Instantiate(AxeWeapons, transform.position, new Quaternion());
            projectiles_Axe ScAxe = curAxe.GetComponent<projectiles_Axe>();
            if (ScAxe != null)
            {
                _loaded=false ;
                float Diraction = 1;
                if (transform.parent != null)
                    Diraction = transform.parent.localScale.x;
                ScAxe.Soot(Diraction);
                AmmoManger.Instance.axeAmmo.DecreseAmmo();
            }
        }
    }

    public void Relode()
    {
        _loaded=true ;
    }

    
}
