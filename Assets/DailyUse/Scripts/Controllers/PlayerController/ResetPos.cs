using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ResetPos : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 Player_Start_Pos; 
    private void Awake()
    {
        Player_Start_Pos=GetComponent<Transform>().position;
    }
    public void ResetPosi()
    {
        gameObject.transform.position = Player_Start_Pos;
    }
}
