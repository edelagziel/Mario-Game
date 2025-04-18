using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Jump : MonoBehaviour
{
    Rigidbody2D rb;
    private bool _Isjumping=false;
    [SerializeField] private float _SpeedJump=10;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        if (rb != null&& _Isjumping==false)
        {
            rb.AddForce(new Vector2 (transform.position.x, _SpeedJump));
            _Isjumping=true;

        }
    }

    public void ResetJump()
    {
        _Isjumping=false;
    }
}
