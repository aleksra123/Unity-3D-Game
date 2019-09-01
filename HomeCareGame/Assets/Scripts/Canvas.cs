using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas : MonoBehaviour {
    public GameObject panel;
    GameObject GMobj;
    GameManager instance;
    // Use this for initialization
    void Start () {
        
        if (instance.currentLevelByInt != 0)
        {
            panel.SetActive(false);
        }
        if(instance.currentLevelByInt == 0)
        {
            panel.SetActive(true);
        }
    }

    void Awake()
    {
        GMobj = GameObject.Find("GameManager");
        instance = GMobj.GetComponent<GameManager>();
    }


    // Update is called once per frame
    void Update () {
		
	}
}
