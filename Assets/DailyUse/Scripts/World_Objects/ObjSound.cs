using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSound : MonoBehaviour
{
    public void PlaySound(ISound_Play Sound)
    {
        Sound.PlayObjSound(this.gameObject);
    }
}
