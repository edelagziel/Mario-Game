using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using TMPro;

public class MyPlayer_Healt :  IHealthManager
{
    private int CurPlayerHealth = 3;
    private int Add_Health = 1;
    private int Remove_Health = 1;

    public void AddHealth(TextMeshProUGUI _HealtText, ref int CurHealte)
    {
        CurHealte += Add_Health;
        _HealtText.text = "Healt : " + CurHealte;

    }


    public void RemoveHealth(TextMeshProUGUI _HealtText, ref int CurHealte)
    {
        CurHealte -= Remove_Health;
        _HealtText.text = "Healt : " + CurHealte;
    }

    public void ResatHelth(TextMeshProUGUI _HealtText, ref int CurHealte)
    {
        CurHealte = CurPlayerHealth;
        _HealtText.text = "Healt : " + CurHealte;
    }
}
