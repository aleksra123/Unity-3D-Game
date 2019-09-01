using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour  {
    public Text timerText;
    public static float timer;
    public static bool timeStarted;
    public static Timer instance;
    public string m_MyLastScene;
    public string m_CarScene;
    public GameObject MyPlane;
    GameObject GMObj;
    GameManager gameManager;

    void Awake()
    {
        GMObj = GameObject.Find("GameManager");
        gameManager = GMObj.GetComponent<GameManager>();
        MakeThisTheOnlyTimer();
    }
   
    void MakeThisTheOnlyTimer()
    {
        if (instance == null)
        {
            timeStarted = true;
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
    public void MyDestroy()
    {
        Destroy(gameObject);
    }


    void Update()
    {
        if (timeStarted == true && timer != 0)
        {
            timer -= Time.deltaTime;

            int minutes = Mathf.FloorToInt(timer / 60F);
            int seconds = Mathf.FloorToInt(timer - minutes * 60);

            timerText.text = minutes + ":" + seconds;
        }

        if (timer < 0 && timeStarted)
        {
            timerText.text = "TIME'S UP!";
            gameManager.score = 0;
            timeStarted = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);

        }
        if (SceneManager.GetActiveScene().name == m_MyLastScene)
        {

            timeStarted = false;
            MyPlane.SetActive(true);

        }
        if (SceneManager.GetActiveScene().name == m_CarScene)
        {
            timeStarted = true;
            MyPlane.SetActive(false);
        }
    }
}
