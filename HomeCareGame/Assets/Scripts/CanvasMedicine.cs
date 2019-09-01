using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasMedicine : MonoBehaviour {

    GameObject pillHuman;


    void Start () {


        GameObject.Find("DressHuman").SetActive(false);
        pillHuman = GameObject.Find("PillHuman");
        pillHuman.SetActive(true);
        pillHuman.transform.position = new Vector3((float)-8.5, (float)1.35, (float)-1.2);
        Quaternion q = pillHuman.transform.rotation;
        q.eulerAngles = new Vector3(-90, 180, 0);
        pillHuman.transform.rotation = q;


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
