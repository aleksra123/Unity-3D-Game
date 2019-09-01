using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DrivingCarScene : MonoBehaviour {

    GameObject carForSinglePlayer;
    GameObject GMobj;
    GameManager instance;
    public GameObject greenArrowTut;
    public GameObject greenArrow1;
    public GameObject greenArrow2;
    public GameObject greenArrow3;
    public GameObject greenArrow4;


    void Awake()
    {

        GMobj = GameObject.Find("GameManager");
        instance = GMobj.GetComponent<GameManager>();
        carForSinglePlayer = GameObject.Find("Car");

    }


    public void Start() {

        if (instance.multiplayer == true){
            carForSinglePlayer.SetActive(false);
        }
        if (instance.houseTutorialDone) { greenArrowTut.SetActive(false); } else { greenArrowTut.SetActive(true); }
        if (instance.houseOneDone) { greenArrow1.SetActive(false); } else { greenArrow1.SetActive(true); }
        if (instance.houseTwoDone) { greenArrow2.SetActive(false); } else { greenArrow2.SetActive(true); }
        if (instance.houseThreeDone) { greenArrow3.SetActive(false); } else { greenArrow3.SetActive(true); }
        if (instance.houseFourDone) { greenArrow4.SetActive(false); } else { greenArrow4.SetActive(true); }

        if (instance.currentLevelByInt == 0){
            greenArrow1.SetActive(false);
            greenArrow2.SetActive(false);
            greenArrow3.SetActive(false);
            greenArrow4.SetActive(false);
            greenArrowTut.GetComponent<Animator>().Play("greenArrowTut");
        }
        else if (instance.currentLevelByInt == 1)
        {
            greenArrowTut.SetActive(false);
            greenArrow2.SetActive(false);
            greenArrow3.SetActive(false);
            greenArrow4.SetActive(false);

            greenArrow1.GetComponent<Animator>().Play("greenArrowL1");
        }
        else if (instance.currentLevelByInt == 2)
        {
            greenArrow1.SetActive(false);
            greenArrow3.SetActive(false);
            greenArrow4.SetActive(false);

            greenArrowTut.GetComponent<Animator>().Play("greenArrowTut");
            greenArrow2.GetComponent<Animator>().Play("greenArrowL2");

        }
        else if (instance.currentLevelByInt == 3)
        {
            greenArrowTut.SetActive(false);
            greenArrow2.SetActive(false);
            greenArrow4.SetActive(false);

            greenArrow1.GetComponent<Animator>().Play("greenArrowL1");
            greenArrow3.GetComponent<Animator>().Play("greenArrowL3");
        }
        else if (instance.currentLevelByInt == 4)
        {
            greenArrowTut.SetActive(false);
            greenArrow1.SetActive(false);
            greenArrow2.GetComponent<Animator>().Play("greenArrowL2");
            greenArrow3.GetComponent<Animator>().Play("greenArrowL3");
            greenArrow4.GetComponent<Animator>().Play("greenArrowL4");
        }
    }

    public void skipButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
