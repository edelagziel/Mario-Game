using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AxeAmmo : MonoBehaviour,IDecreaseAmmo, ICollectableAmmo,IHaveAmmo
{
    [SerializeField]private int Axe_Ammo_Amount = 0;
    [SerializeField] public TextMeshProUGUI _AmmoText;

    int AddAmount = 1;
    int DecreseAmount = 1;
    public void Awake()
    {
        _AmmoText.text = "Axe : " + Axe_Ammo_Amount;
    }
    public void AddAmmo()
    {
        
        Axe_Ammo_Amount += AddAmount;
        _AmmoText.text = "Axe : " + Axe_Ammo_Amount;

    }

    public void DecreseAmmo()
    {
        Axe_Ammo_Amount -= AddAmount;
        _AmmoText.text = "Axe : " + Axe_Ammo_Amount;

    }

    public bool HasAmmo()
    {
     if(Axe_Ammo_Amount > 0)
            return true;
     return false;
    }
    public void ReastetAmmo()
    {
        Axe_Ammo_Amount = 0;
        _AmmoText.text = "Axe : " + Axe_Ammo_Amount;
    }

}
