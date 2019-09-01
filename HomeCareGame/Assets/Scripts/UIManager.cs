using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class UIManager : MonoBehaviour
{


    public void RestartButtonPushed()
    {
        SceneManager.LoadScene(3);  //goes directly to the drivingCar-scene
    }
    public void MainMenuButtonPushed()
    {
        SceneManager.LoadScene(0);  //goes directly to the mainMenu-scene
    }

    public void NextButtonPushed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //goes directly to the next scene
    }

    GameObject[] pauseObjects;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        hidePaused();
    }

    // Update is called once per frame

    public void OnMouseDown()
    { //STILL WORKING ON THIS ONE, DOESNT WORK YET
        
        if (EventSystem.current.currentSelectedGameObject.name == "PauseButton")
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                showPaused();
            }
            else if (Time.timeScale == 0)
            {
                Debug.Log("high");
                Time.timeScale = 1;
                hidePaused();
            }

        }


    }

    void Update()
        {

            //uses the p button to pause and unpause the game
            if (Input.GetKeyDown(KeyCode.P))
            {
                if (Time.timeScale == 1)
                {
                    Time.timeScale = 0;
                    showPaused();
                }
                else if (Time.timeScale == 0)
                {
                    Debug.Log("high");
                    Time.timeScale = 1;
                    hidePaused();
                }
            }
           
        }

    //Reloads the Level
    public void Reload()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    //controls the pausing of the scene
    public void pauseControl()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            showPaused();
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            hidePaused();
        }
    }

    //shows objects with ShowOnPause tag
    public void showPaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
    }

    //hides objects with ShowOnPause tag
    public void hidePaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }

    //loads inputted level
    public void LoadLevel(string level)
    {
        Application.LoadLevel(level);
    }
}