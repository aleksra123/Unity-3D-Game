using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class levelManagerFunctions : MonoBehaviour {

    GameObject GMobj;
    GameManager instance;
    GameObject levelCanvas;
    // Use this for initialization
    void Start () {
        levelCanvas = GameObject.Find("CanvasChooseLevel");
        GMobj = GameObject.Find("GameManager");
        instance = GMobj.GetComponent<GameManager>();
    }
	
    public void OnLevelClick(){
        instance.houseTutorialDone = false;
        instance.houseOneDone = false;
        instance.houseTwoDone = false;
        instance.houseThreeDone = false;
        instance.houseFourDone = false;
        instance.score = 0;
        if (instance.currentLevelByInt == 0 || instance.currentLevelByInt == 1)
        {
            Timer.timer = 90;
        }
        else if (instance.currentLevelByInt == 2 || instance.currentLevelByInt == 3)
        {
            Timer.timer = 120;
        }
        else { Timer.timer = 150; }

    }

    public void OnSingleplayerClick(){
        instance.multiplayer = false;
    }

    public void OnMultiplayerClick()
    {
        instance.multiplayer = true;
        GMobj.GetComponent<NetworkLobbyManager>().enabled = !GMobj.GetComponent<NetworkLobbyManager>().enabled;
        GMobj.GetComponent<NetworkManagerHUD>().enabled = !GMobj.GetComponent<NetworkManagerHUD>().enabled;
    }

    public void NotTutorialLoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
