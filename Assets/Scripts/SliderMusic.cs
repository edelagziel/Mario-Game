using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderMusic : MonoBehaviour
{
    public GameObject AudioManger;
    public void ControllGameSound()
    {
        AudioManger.GetComponent<AudioSource>().volume = gameObject.GetComponent<Slider>().value/10;
    }
}
