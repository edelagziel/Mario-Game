using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObjEnable : MonoBehaviour, Ireset
{
    public void ResetObject()
    {
        this.gameObject.SetActive(true);
    }
}
