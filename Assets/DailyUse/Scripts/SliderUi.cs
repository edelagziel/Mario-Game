using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SliderUi : MonoBehaviour
{
    public void SliderTextValu()
    {
        TMP_Text textComponent = GetComponentInChildren<TMP_Text>();
        textComponent.text=gameObject.GetComponent<Slider>().value.ToString();
    }
}
