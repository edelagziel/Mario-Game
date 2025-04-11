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
            PlayerResetPos Temp = collision.gameObject.GetComponent<PlayerResetPos>();
            if (Temp!=null)
            {
                Temp.ResetPos();
            }
        }
    }
}
