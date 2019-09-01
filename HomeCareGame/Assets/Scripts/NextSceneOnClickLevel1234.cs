using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class NextSceneOnClickLevel1234 : MonoBehaviour {
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
        if ((instance.currentLevelByInt == 1 || instance.currentLevelByInt == 3) && !instance.houseOneDone)
        {
            instance.houseNumberByInt = 1;
            if (instance.multiplayer)
            {
                NLM.ServerChangeScene("InsideHouse");
                instance.houseOneDone = true;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                instance.houseOneDone = true;
            }
        }
    }
}