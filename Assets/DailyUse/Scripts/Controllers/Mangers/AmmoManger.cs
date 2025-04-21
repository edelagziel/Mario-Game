using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoManger : MonoBehaviour
{
    // Start is called before the first frame update
    public static AmmoManger Instance;
    public AxeAmmo axeAmmo;
    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

  
}
