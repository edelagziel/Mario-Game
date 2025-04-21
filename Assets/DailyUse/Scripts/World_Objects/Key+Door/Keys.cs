using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    //i can use later in Dic In order to Expaned 
     bool Isopen=false;
    public bool Get_Open_Status()
    {
        return Isopen;
    }
    public void Key_Open(Iopenable iopenable)
    {
        iopenable.Open( ref Isopen);
    }
    public void Key_Reset(Iopenable iopenable)
    {
        iopenable.Reset(ref Isopen);
    }
}
