using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectiles_Fireaball : MonoBehaviour
{
    public float speed = 5f;
    public float destroyTime = 2.5f;
    private Rigidbody2D _Rigid;
    private void Awake()
    {
        _Rigid=gameObject.GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
         
    }


    public void Soot(float diraction)
    {
        if (_Rigid != null)
        {
            transform.localScale = new Vector3(diraction, 1, 1);
            _Rigid.AddForce(new Vector2(speed * diraction, 0));
            StartCoroutine(DestroyObject());
        }
    }


    private IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(destroyTime);
        Destroy(this.gameObject);
    }
}



