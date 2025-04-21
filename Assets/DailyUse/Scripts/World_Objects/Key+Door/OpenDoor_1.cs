using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor_1 : Iopenable
{
    bool Door_Open=false;
   
    public void Open(ref bool Isopen)
    {
        
            Isopen=true;
            Debug.Log("Door is Open");
        
    }

    public void Reset(ref bool Isopen)
    {
        Isopen = Door_Open;
    }
}
