using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camra_Sc : MonoBehaviour, IfollowTarget
{
    [SerializeField]private GameObject Player;
    private float Mrio_Pos;

    private void Awake()
    {
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        FollowTransform();
    }

   

    public void FollowTransform()
    {
        Mrio_Pos = Player.gameObject.GetComponent<Transform>().position.x;

        if (Player != null)
        {
            this.transform.position = new Vector3(Mrio_Pos, transform.position.y, transform.position.z);
        }
    }
}
