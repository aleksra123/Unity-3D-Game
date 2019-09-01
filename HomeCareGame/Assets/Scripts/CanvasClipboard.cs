using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasClipboard : MonoBehaviour {

    public Text clipboard0;
    public Text clipboard1;
    public Text clipboard2;
    public Text clipboard3;
    public Text clipboard4;
    public Text clipboard0patientName;
    public Text clipboard1patientName;
    public Text clipboard2patientName;
    public Text clipboard3patientName;
    public Text clipboard4patientName;


  GameObject GMobj;
  GameManager instance;

   void Awake()
      {
  	GMobj=GameObject.Find("GameManager");
  	instance=GMobj.GetComponent<GameManager>();

  	}
    GameObject myCamera;

    // Use this for initialization
    void Start () {
clipboard0.enabled = false;
clipboard1.enabled = false;
clipboard2.enabled = false;
clipboard3.enabled = false;
clipboard4.enabled = false;

clipboard0patientName.enabled =false;
clipboard1patientName.enabled =false;
clipboard2patientName.enabled =false;
clipboard3patientName.enabled =false;
clipboard4patientName.enabled =false;

    myCamera = GameObject.Find("Main Camera 2");

    if(instance.houseNumberByInt==0){
          clipboard0.enabled = true;
          clipboard0patientName.enabled =true;
        }

    if(instance.houseNumberByInt==1){
	        clipboard1.enabled = true;
          clipboard1patientName.enabled =true;
        }

    if(instance.houseNumberByInt==2){
        clipboard2.enabled = true;
        clipboard2patientName.enabled =true;
      }

    if(instance.houseNumberByInt==3){
        clipboard3.enabled = true;
        clipboard3patientName.enabled =true;
      }

      if(instance.houseNumberByInt==4){
        clipboard4.enabled = true;
        clipboard4patientName.enabled =true;
      }


    }

    // Update is called once per frame
    void Update () {

	}
}
