using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    private float _jumpOfset = 0.45f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null && collision.gameObject.tag == "Player")
        {
            Player_Jump Temp = collision.gameObject.GetComponent<Player_Jump>();
            if (Temp != null && Temp)
            {
                float playerYPosition = collision.gameObject.transform.position.y;
                float FloorYPosition = this.transform.position.y;
                if (playerYPosition > FloorYPosition + _jumpOfset)
                {
                    Temp.ResetJump();
                    Debug.Log("ResetActive");
                }
            }
        }
    }
}
