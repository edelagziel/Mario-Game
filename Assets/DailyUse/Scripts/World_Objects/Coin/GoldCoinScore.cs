using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;


public class GoldCoinScore :MonoBehaviour, Iscore
{
    // Start is called before the first frame update
   [SerializeField] public TextMeshProUGUI _scoreText;

    public int CoinsAmount=0;
    //private void OnEnable()
    //{
    //    GoldCoins_Triger.Coin_collision += UpdateScoreAmountAdd;

    //}
    //private void OnDisable()
    //{
    //    GoldCoins_Triger.Coin_collision -= UpdateScoreAmountAdd;
    //}
   

    public void IncreaseScore()
    {
        CoinsAmount++;
        _scoreText.text = "Score : " + CoinsAmount;
    }

    public void DecressScore()
    {
        CoinsAmount--;
        _scoreText.text = "Score : " + CoinsAmount;
    }
}
