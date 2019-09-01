using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasMakeFood : MonoBehaviour {

    GameObject GMobj;
    GameManager instance;
    private float timer;
    private bool started;
    GameObject fader;

    public GameObject carrots;
    private float carrotTimer;
    public Text carrotTimerText;
    public GameObject stopCarrotButton;

    public GameObject potatoes;
    private float potatoeTimer;
    public Text potatoeTimerText;
    public GameObject stopPotatoeButton;

    public GameObject stopSquashButton;
    public GameObject squash;

    public GameObject stopAubergineButton;
    public GameObject aubergine;


    public GameObject chicken;
    private float chickenTimer;
    public Text chickenTimerText;
    public GameObject stopChickenButton;




    // Use this for initialization

    void Start () {
        timer = 2;
        started = true;
        fader = GameObject.Find("Fader_Food");
        GMobj = GameObject.Find("GameManager");
        instance = GMobj.GetComponent<GameManager>();

        carrotTimer = 8;
        stopCarrotButton.SetActive(false);

        potatoeTimer = 10;
        stopPotatoeButton.SetActive(false);

        stopSquashButton.SetActive(false);

        stopAubergineButton.SetActive(false);

        chickenTimer = 6;
        stopChickenButton.SetActive(false);
    }

	// Update is called once per frame
	void Update () {
        if (started)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                started = false;
                fader.SetActive(false);

            }
        }
        if (carrots.activeSelf){
            stopCarrotButton.SetActive(true);
            carrotTimer -= Time.deltaTime;
            if (carrotTimer < 0)
            {
                int seconds = Mathf.CeilToInt(carrotTimer);
                float milliseconds = Mathf.Abs(Mathf.CeilToInt(10 * (carrotTimer - seconds)));
                carrotTimerText.text = seconds + ":" + milliseconds;
                if (seconds == 0)
                {
                    carrotTimerText.text = "-" + seconds + ":" + milliseconds;
                }
            }
            else
            {
                int seconds = Mathf.FloorToInt(carrotTimer);
                float milliseconds = Mathf.FloorToInt(10 * (carrotTimer - seconds));
                carrotTimerText.text = seconds + ":" + milliseconds;
            }
        }
        if (potatoes.activeSelf)
        {
            stopPotatoeButton.SetActive(true);
            potatoeTimer -= Time.deltaTime;
            if (potatoeTimer < 0)
            {
                int seconds = Mathf.CeilToInt(potatoeTimer);
                float milliseconds = Mathf.Abs(Mathf.CeilToInt(10 * (potatoeTimer - seconds)));
                potatoeTimerText.text = seconds + ":" + milliseconds;
                if (seconds == 0)
                {
                    potatoeTimerText.text = "-" + seconds + ":" + milliseconds;
                }
            }
            else
            {
                int seconds = Mathf.FloorToInt(potatoeTimer);
                float milliseconds = Mathf.FloorToInt(10 * (potatoeTimer - seconds));
                potatoeTimerText.text = seconds + ":" + milliseconds;
            }
        }
        if (chicken.activeSelf)
        {
            stopChickenButton.SetActive(true);
            chickenTimer -= Time.deltaTime;
            if (chickenTimer < 0)
            {
                int seconds = Mathf.CeilToInt(chickenTimer);
                float milliseconds = Mathf.Abs(Mathf.CeilToInt(10 * (chickenTimer - seconds)));
                chickenTimerText.text = seconds + ":" + milliseconds;
                if (seconds == 0){
                    chickenTimerText.text = "-" + seconds + ":" + milliseconds;
                }
            } else{
                int seconds = Mathf.FloorToInt(chickenTimer);
                float milliseconds = Mathf.FloorToInt(10 * (chickenTimer - seconds));
                chickenTimerText.text = seconds + ":" + milliseconds;
            }


        }



        if (squash.activeSelf)
        {
            stopSquashButton.SetActive(true);
            potatoeTimer -= Time.deltaTime;
            if (potatoeTimer < 0)
            {
                int seconds = Mathf.CeilToInt(potatoeTimer);
                float milliseconds = Mathf.Abs(Mathf.CeilToInt(10 * (potatoeTimer - seconds)));
                potatoeTimerText.text = seconds + ":" + milliseconds;
                if (seconds == 0){
                    potatoeTimerText.text = "-" + seconds + ":" + milliseconds;
                }
            } else{
                int seconds = Mathf.FloorToInt(potatoeTimer);
                float milliseconds = Mathf.FloorToInt(10 * (potatoeTimer - seconds));
                potatoeTimerText.text = seconds + ":" + milliseconds;
            }


        }

        if (aubergine.activeSelf)
        {
            stopAubergineButton.SetActive(true);
            potatoeTimer -= Time.deltaTime;
            if (potatoeTimer < 0)
            {
                int seconds = Mathf.CeilToInt(potatoeTimer);
                float milliseconds = Mathf.Abs(Mathf.CeilToInt(10 * (potatoeTimer - seconds)));
                potatoeTimerText.text = seconds + ":" + milliseconds;
                if (seconds == 0){
                    potatoeTimerText.text = "-" + seconds + ":" + milliseconds;
                }
            } else{
                int seconds = Mathf.FloorToInt(potatoeTimer);
                float milliseconds = Mathf.FloorToInt(10 * (potatoeTimer - seconds));
                potatoeTimerText.text = seconds + ":" + milliseconds;
            }


        }



    }

    public void determineNextScene(){

        instance.housesToVisit--;
        if (instance.housesToVisit == 0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }else{
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }


    }

    public void carrotButton(){
        carrots.SetActive(false);
        instance.score += 300 - (int)Mathf.Abs(carrotTimer)*300;
        stopCarrotButton.SetActive(false);
    }

    public void squashButton(){
        squash.SetActive(false);
        instance.score += 300 - (int)Mathf.Abs(potatoeTimer)*300;
        stopSquashButton.SetActive(false);
    }

    public void aubergineButton(){
        aubergine.SetActive(false);
        instance.score += 300 - (int)Mathf.Abs(potatoeTimer)*300;
        stopAubergineButton.SetActive(false);
    }
    public void potatoeButton()
    {
        potatoes.SetActive(false);
        instance.score += 300 - (int)Mathf.Abs(potatoeTimer)*300;
        stopPotatoeButton.SetActive(false);
    }
    public void chickenButton()
    {
        chicken.SetActive(false);
        instance.score += 300 - (int)Mathf.Abs(chickenTimer)*300;
        stopChickenButton.SetActive(false);
    }
}
