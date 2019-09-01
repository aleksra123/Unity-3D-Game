using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class NextSceneOnClick : MonoBehaviour {

    GameObject GMobj;
    GameManager instance;
    NetworkLobbyManager NLM;

    void Awake()
    {

        GMobj = GameObject.Find("GameManager");
        instance = GMobj.GetComponent<GameManager>();
        NLM = GMobj.GetComponent<NetworkLobbyManager>();
    }

    public void OnMouseDown()
    {
        if (!instance.houseTutorialDone && (instance.currentLevelByInt == 0 || instance.currentLevelByInt == 2))
        {
            instance.houseNumberByInt = 0;
            if (instance.multiplayer)
            {
                NLM.ServerChangeScene("InsideHouse");
                instance.houseTutorialDone = true;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                instance.houseTutorialDone = true;
            }
        }
    }
}
