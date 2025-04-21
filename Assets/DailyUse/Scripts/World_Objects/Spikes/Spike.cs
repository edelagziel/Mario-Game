using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spike : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision != null&& collision.gameObject.tag=="Player")
        {
            ResetPos Temp = collision.gameObject.GetComponent<ResetPos>();
            if (Temp!=null)
            {
                Temp.ResetPosi();
                
            }
        }
    }
}
