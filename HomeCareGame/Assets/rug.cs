using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rug : MonoBehaviour {

	public GameObject rugC;
	public GameObject rugRed;


	  GameObject GMobj;
	  GameManager instance;
	// Use this for initialization
	void Start () {
			if (instance.houseNumberByInt == 1) {
				rugC.SetActive(false);
				rugRed.SetActive(true);
			}
			if (instance.houseNumberByInt == 0) {
				rugC.SetActive(false);
				rugRed.SetActive(false);
			}
			if (instance.houseNumberByInt == 2) {
				rugC.SetActive(true);
				rugRed.SetActive(false);
			}
			if (instance.houseNumberByInt == 3) {
				rugC.SetActive(false);
				rugRed.SetActive(true);
			}
	}
	void Awake(){
		GMobj = GameObject.Find("GameManager");
		instance = GMobj.GetComponent<GameManager>();

	}

	// Update is called once per frame
	void Update () {

	}
}
