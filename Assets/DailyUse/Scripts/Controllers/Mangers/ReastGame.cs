using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ReastGame : MonoBehaviour
{
    public static event Action MarioReast_Game;
   public void PlayAgine()
    {
        MarioReast_Game?.Invoke();
    }
}
