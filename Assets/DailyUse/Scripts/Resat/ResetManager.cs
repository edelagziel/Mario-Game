using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ResetManager : MonoBehaviour
{
    private Ireset[] resettableObjects;
    public GameObject World;
    public GameObject Game_Over;
    public GameObject YouWin;

    private void OnEnable()
    {
        ReastGame.MarioReast_Game += ResetAll;

    }
    private void OnDisable()
    {
        ReastGame.MarioReast_Game -= ResetAll;

    }

    private void Awake()
    {
        resettableObjects = FindObjectsOfType<MonoBehaviour>(true).OfType<Ireset>().ToArray();
    }

    public void ResetAll()
    {
        
            World.SetActive(true);
            Game_Over.SetActive(false);
            YouWin.SetActive(false);



        foreach (var obj in resettableObjects)
        {
            obj.ResetObject();
        }
      

    }

}
