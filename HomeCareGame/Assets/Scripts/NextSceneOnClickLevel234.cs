using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class NextSceneOnClickLevel234 : MonoBehaviour {
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
        if ((instance.currentLevelByInt == 2 || instance.currentLevelByInt == 4) && !instance.houseTwoDone)
        {
            instance.houseNumberByInt = 2;
            if (instance.multiplayer)
            {
                NLM.ServerChangeScene("InsideHouse");
                instance.houseTwoDone = true;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                instance.houseTwoDone = true;
            }

        }

    }
}
