using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Obj_SoundPlay : MonoBehaviour, ISound_Play
{

    private void Awake()
    {

    }

     public void PlayObjSound(GameObject obj)
     {  
        AudioClip myClip = obj.GetComponent<AudioSource>()?.clip;
        if (myClip != null)
        {
            AudioSource.PlayClipAtPoint(myClip, obj.transform.position);
        }
     }

}
