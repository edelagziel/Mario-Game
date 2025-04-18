using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisabledObj : MonoBehaviour
{
    private float _disableTime=0.5f;
    private Renderer _renderer;
    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    public void ActiveDisable()
    {
        StartCoroutine(DisableAfterDelay());
    }

    IEnumerator DisableAfterDelay()
    {
        _renderer.enabled = false;
        yield return new WaitForSeconds(_disableTime);
        this.gameObject.SetActive(false);
        _renderer.enabled = true;
    }
}
