using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movment : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D _rb;
    private float _direction;
    [SerializeField]private float _speed=500f;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _direction = Input.GetAxis("Horizontal");
       

    }
    private void FixedUpdate()
    {
        if (_rb != null && _direction != 0)
        {
            if (_direction < 0) transform.localScale=new Vector3(-1, transform.localScale.y, transform.localScale.z);
            else  transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
            _rb.velocity = new Vector2(_direction * _speed, transform.position.y);
        }
    }
}
