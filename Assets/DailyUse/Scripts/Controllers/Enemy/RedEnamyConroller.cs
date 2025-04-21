using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEnamyConroller : MonoBehaviour,Ireset
{
    Obj_Healt obj_Healt;
    private void Awake()
    {
         obj_Healt = GetComponent<Obj_Healt>();
    }
    private void OnEnable()
    {
        //ReastGame.MarioReast_Game += ResetRedEnemy;

    }
    private void OnDisable()
    {
       // ReastGame.MarioReast_Game -= ResetRedEnemy;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collied");

        if (collision != null && collision.gameObject.tag == "EnemyKill" )
        {
            obj_Healt.RadusHealt(new RedEnamyHelt());
            collision.gameObject.SetActive(false);
            if(obj_Healt.GetObjHelte()<=0)
            {
                this.gameObject.SetActive(false);
            }
            Debug.Log("Hited");
           

        }
    }
    

    public void ResetObject()
    {
        this.gameObject.SetActive(true);
        obj_Healt.ReastHealt(new RedEnamyHelt());
    }
}
