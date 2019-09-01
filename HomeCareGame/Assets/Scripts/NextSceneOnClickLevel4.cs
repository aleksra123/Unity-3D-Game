using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class NextSceneOnClickLevel4 : MonoBehaviour {

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
        if (instance.currentLevelByInt == 4 && !instance.houseFourDone)
        {
            instance.houseNumberByInt = 4;
            if (instance.multiplayer)
            {
                NLM.ServerChangeScene("InsideHouse");
                instance.houseFourDone = true;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                instance.houseFourDone = true;
            }
        }

    }
}
