using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelmanager : MonoBehaviour {

    GameObject GMobj;
    GameManager instance;
    public Button m_LevelTutorialButton;
    public Button m_LevelOneButton;
    public Button m_LevelTwoButton;
    public Button m_LevelThreeButton;
    public Button m_LevelFourButton;



    // Use this for initialization
    void Start () {



        m_LevelTutorialButton.onClick.AddListener(TaskOnClick0);
        m_LevelOneButton.onClick.AddListener(TaskOnClick1);
        m_LevelTwoButton.onClick.AddListener(TaskOnClick2);
        m_LevelThreeButton.onClick.AddListener(TaskOnClick3);
        m_LevelFourButton.onClick.AddListener(TaskOnClick4);
        
    }


    void TaskOnClick0()
    {
        instance.currentLevelByInt = 0;
        instance.housesToVisit = 1;
    }
    void TaskOnClick1()
    {
        instance.currentLevelByInt = 1;
        instance.housesToVisit = 1;
    }
    void TaskOnClick2()
    {
        instance.currentLevelByInt = 2;
        instance.housesToVisit = 2;
    }
    void TaskOnClick3()
    {
        instance.currentLevelByInt = 3;
        instance.housesToVisit = 2;
    }
    void TaskOnClick4()
    {
        instance.currentLevelByInt = 4;
        instance.housesToVisit = 3;
    }



    void Awake()
    {
        m_LevelOneButton.interactable = true;
        m_LevelTwoButton.interactable = false;
        m_LevelThreeButton.interactable = false;
        m_LevelFourButton.interactable = false;

        GMobj = GameObject.Find("GameManager");
        instance = GMobj.GetComponent<GameManager>();

        if (instance.score > 600 && instance.currentLevelByInt == 1)
        {
            instance.LevelTwoOpened = true;
        }
        if (instance.score > 1200 && instance.currentLevelByInt == 2)
        {
            instance.LevelThreeOpened = true;
        }
        if (instance.score > 1400 && instance.currentLevelByInt == 3)
        {
            instance.LevelFourOpened = true;
        }

        if (instance.LevelTwoOpened){
            m_LevelTwoButton.interactable = true;
        }
        if (instance.LevelThreeOpened)
        {
            m_LevelThreeButton.interactable = true;
        }
        if (instance.LevelFourOpened)
        {
            m_LevelFourButton.interactable = true;
        }
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
