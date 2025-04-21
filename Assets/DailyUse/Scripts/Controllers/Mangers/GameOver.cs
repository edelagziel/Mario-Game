using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField]GameObject World,Game_Over,YouWon;
    

    private void OnEnable()
    {
        PlayerControlCollide.OnPlayerDied += HandleGameOverLose;
        Door_Controler.OnplayerWin += HandleGameOverWin;

    }
    private void OnDisable()
    {
        PlayerControlCollide.OnPlayerDied -= HandleGameOverLose;
        Door_Controler.OnplayerWin -= HandleGameOverWin;



    }
    private void HandleGameOverLose()
    {
        World.SetActive(false);
        Game_Over.SetActive(true);
    }
    private void HandleGameOverWin()
    {
        World.SetActive(false);
        Game_Over.SetActive(false);
        YouWon.SetActive(true);
    }

}
