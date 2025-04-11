using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinSoundPlay : MonoBehaviour
{
    [SerializeField] AudioClip CoinTaken;
    AudioSource CoinAudio;
    private void Awake()
    {
        //CoinTaken=gameObject.GetComponent<AudioClip>();
         CoinAudio= gameObject.GetComponent<AudioSource>();
    }
    private void OnEnable()
    {
        Coins_Triger.Coin_collision += CoinSound;
    }
    private void OnDisable()
    {
        Coins_Triger.Coin_collision -= CoinSound;
    }
    private void CoinSound()
    {
        //CoinAudio.PlayOneShot(CoinTaken);
        AudioSource.PlayClipAtPoint(CoinTaken, transform.position);

    }
}
