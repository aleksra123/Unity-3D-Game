 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public int score;
    public int currentLevelByInt;
    public int houseNumberByInt;
    public int housesToVisit;

    public bool houseTutorialDone;
    public bool houseOneDone;
    public bool houseTwoDone;
    public bool houseThreeDone;
    public bool houseFourDone;
    public bool LevelOneOpened = true;
    public bool LevelTwoOpened;
    public bool LevelThreeOpened;
    public bool LevelFourOpened;
    public bool multiplayer;


    void Awake()
    {
        MakeThisTheOnlyGameManager();
    }


    void Update()
    {
      //Debug.Log(houseNumberByInt);


    }
    void MakeThisTheOnlyGameManager()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
    }

}
