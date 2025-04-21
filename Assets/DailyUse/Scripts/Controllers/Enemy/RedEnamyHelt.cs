using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RedEnamyHelt : IHealthManager
{
    private int CurPlayerHealth = 1;
    private int Add_Health = 1;
    private int Remove_Health = 1;

    public void AddHealth(TextMeshProUGUI _HealtText, ref int CurHealte)
    {
        CurHealte += Add_Health;
        if (_HealtText != null)
        {
            _HealtText.text = "Health: " + CurHealte;
        }

    }


    public void RemoveHealth(TextMeshProUGUI _HealtText, ref int CurHealte)
    {
        CurHealte -= Remove_Health;
        if (_HealtText != null)
        {
            _HealtText.text = "Health: " + CurHealte;
        }
    }

    public void ResatHelth(TextMeshProUGUI _HealtText, ref int CurHealte)
    {
        CurHealte = CurPlayerHealth;
        if (_HealtText != null)
        {
            _HealtText.text = "Health: " + CurHealte;
        }
    }
}
