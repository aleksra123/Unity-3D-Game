using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetWallColour : MonoBehaviour {

	// Use this for initialization
	public GameObject H0W;
	public GameObject H0LW;
	public GameObject H0RW;

	public  Material m_Material1;
	public  Material m_Material2;
	public  Material m_Material3;
	public  Material m_Material4;


	GameObject GMobj;
	GameManager instance;


	void Start () {
			if(instance.houseNumberByInt==1){
				H0W.GetComponent<Renderer>().material=m_Material1;
				H0LW.GetComponent<Renderer>().material=m_Material1;
				H0RW.GetComponent<Renderer>().material=m_Material1;


				}
				if(instance.houseNumberByInt==2){
					H0W.GetComponent<Renderer>().material=m_Material2;
					H0LW.GetComponent<Renderer>().material=m_Material2;
					H0RW.GetComponent<Renderer>().material=m_Material2;


					}
					if(instance.houseNumberByInt==3){
						H0W.GetComponent<Renderer>().material=m_Material3;
						H0LW.GetComponent<Renderer>().material=m_Material3;
						H0RW.GetComponent<Renderer>().material=m_Material3;


						}
						if(instance.houseNumberByInt==4){
							H0W.GetComponent<Renderer>().material=m_Material4;
							H0LW.GetComponent<Renderer>().material=m_Material4;
							H0RW.GetComponent<Renderer>().material=m_Material4;


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
