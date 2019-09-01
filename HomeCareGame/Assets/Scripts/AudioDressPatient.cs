using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDressPatient : MonoBehaviour {


    public AudioClip dragnDropDone;
    public AudioSource audioSource;
    GameObject shirt;
    GameObject pants;
    GameObject boxers;
    bool firstTime = true;
    bool firstBoxer = true;
    bool firstPants = true;
    bool firstShirt = true;

    // Use this for initialization
    void Start () {

        audioSource.clip = dragnDropDone;
        pants = GameObject.Find("pants");
        boxers = GameObject.Find("underwear");
        shirt = GameObject.Find("shirt");


    }
	
	// Update is called once per frame
	void Update () {



        if (pants.activeSelf && firstPants)
        {

            pants.GetComponent<AudioSource>().Play();
            firstPants = false;
        }

        if (boxers.activeSelf && firstBoxer){
            boxers.GetComponent<AudioSource>().Play();
            firstBoxer = false;
        } 

       

        if (shirt.activeSelf && firstShirt)
        {
            shirt.GetComponent<AudioSource>().Play();
            firstShirt = false;
        }

        if (shirt.activeSelf && pants.activeSelf && boxers.activeSelf && firstTime)
        {
            audioSource.volume = 2.0f;
            audioSource.PlayOneShot(dragnDropDone);
            firstTime = false;
           
        }
		
	}
}
