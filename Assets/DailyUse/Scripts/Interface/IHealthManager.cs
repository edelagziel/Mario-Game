using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public interface IHealthManager 
{
    void AddHealth(TextMeshProUGUI _HealtText, ref int CurHealte);
    void RemoveHealth(TextMeshProUGUI _HealtText, ref int CurHealte);
    void ResatHelth(TextMeshProUGUI _HealtText, ref int CurHealte);
  
}
