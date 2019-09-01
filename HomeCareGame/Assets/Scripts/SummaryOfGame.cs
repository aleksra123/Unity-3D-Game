using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SummaryOfGame : MonoBehaviour {

    GameObject GMobj;
    GameManager instance;
    public Text highscore1;

    public Text scoreText;

    // Use this for initialization

    void Start() {


        GMobj = GameObject.Find("GameManager");
        instance = GMobj.GetComponent<GameManager>();
        instance.score += 10*(int)Timer.timer;
        scoreText.text = instance.score.ToString();
        if (instance.currentLevelByInt == 1)
        {
            highscore1.text = PlayerPrefs.GetInt("Highscore11", 0).ToString();

            if (instance.score > PlayerPrefs.GetInt("Highscore11"))
            {
                PlayerPrefs.SetInt("Highscore15", PlayerPrefs.GetInt("Highscore14"));
                PlayerPrefs.SetInt("Highscore14", PlayerPrefs.GetInt("Highscore13"));
                PlayerPrefs.SetInt("Highscore13", PlayerPrefs.GetInt("Highscore12"));
                PlayerPrefs.SetInt("Highscore12", PlayerPrefs.GetInt("Highscore11"));
                PlayerPrefs.SetInt("Highscore11", instance.score);
                highscore1.text = instance.score.ToString();
            }
            else if (instance.score > PlayerPrefs.GetInt("Highscore12"))
            {
                PlayerPrefs.SetInt("Highscore15", PlayerPrefs.GetInt("Highscore14"));
                PlayerPrefs.SetInt("Highscore14", PlayerPrefs.GetInt("Highscore13"));
                PlayerPrefs.SetInt("Highscore13", PlayerPrefs.GetInt("Highscore12"));
                PlayerPrefs.SetInt("Highscore12", instance.score);
            }
            else if (instance.score > PlayerPrefs.GetInt("Highscore13"))
            {
                PlayerPrefs.SetInt("Highscore15", PlayerPrefs.GetInt("Highscore14"));
                PlayerPrefs.SetInt("Highscore14", PlayerPrefs.GetInt("Highscore13"));
                PlayerPrefs.SetInt("Highscore13", instance.score);
            }
            else if (instance.score > PlayerPrefs.GetInt("Highscore14"))
            {
                PlayerPrefs.SetInt("Highscore15", PlayerPrefs.GetInt("Highscore14"));
                PlayerPrefs.SetInt("Highscore14", instance.score);
            }
            else if (instance.score > PlayerPrefs.GetInt("Highscore15"))
            {
                PlayerPrefs.SetInt("Highscore15", instance.score);
            }
        }
        else if (instance.currentLevelByInt == 2)
        {
            highscore1.text = PlayerPrefs.GetInt("Highscore21", 0).ToString();

            if (instance.score > PlayerPrefs.GetInt("Highscore21"))
            {
                PlayerPrefs.SetInt("Highscore25", PlayerPrefs.GetInt("Highscore24"));
                PlayerPrefs.SetInt("Highscore24", PlayerPrefs.GetInt("Highscore23"));
                PlayerPrefs.SetInt("Highscore23", PlayerPrefs.GetInt("Highscore22"));
                PlayerPrefs.SetInt("Highscore22", PlayerPrefs.GetInt("Highscore21"));
                PlayerPrefs.SetInt("Highscore21", instance.score);
                highscore1.text = instance.score.ToString();
            }
            else if (instance.score > PlayerPrefs.GetInt("Highscore22"))
            {
                PlayerPrefs.SetInt("Highscore25", PlayerPrefs.GetInt("Highscore24"));
                PlayerPrefs.SetInt("Highscore24", PlayerPrefs.GetInt("Highscore23"));
                PlayerPrefs.SetInt("Highscore23", PlayerPrefs.GetInt("Highscore22"));
                PlayerPrefs.SetInt("Highscore22", instance.score);
            }
            else if (instance.score > PlayerPrefs.GetInt("Highscore23"))
            {
                PlayerPrefs.SetInt("Highscore25", PlayerPrefs.GetInt("Highscore24"));
                PlayerPrefs.SetInt("Highscore24", PlayerPrefs.GetInt("Highscore23"));
                PlayerPrefs.SetInt("Highscore23", instance.score);
            }
            else if (instance.score > PlayerPrefs.GetInt("Highscore24"))
            {
                PlayerPrefs.SetInt("Highscore25", PlayerPrefs.GetInt("Highscore24"));
                PlayerPrefs.SetInt("Highscore24", instance.score);
            }
            else if (instance.score > PlayerPrefs.GetInt("Highscore25"))
            {
                PlayerPrefs.SetInt("Highscore25", instance.score);
            }
        }
        else if (instance.currentLevelByInt == 3)
        {
            highscore1.text = PlayerPrefs.GetInt("Highscore31", 0).ToString();

            if (instance.score > PlayerPrefs.GetInt("Highscore31"))
            {
                PlayerPrefs.SetInt("Highscore35", PlayerPrefs.GetInt("Highscore34"));
                PlayerPrefs.SetInt("Highscore34", PlayerPrefs.GetInt("Highscore33"));
                PlayerPrefs.SetInt("Highscore33", PlayerPrefs.GetInt("Highscore32"));
                PlayerPrefs.SetInt("Highscore32", PlayerPrefs.GetInt("Highscore31"));
                PlayerPrefs.SetInt("Highscore31", instance.score);
                highscore1.text = instance.score.ToString();
            }
            else if (instance.score > PlayerPrefs.GetInt("Highscore32"))
            {
                PlayerPrefs.SetInt("Highscore35", PlayerPrefs.GetInt("Highscore34"));
                PlayerPrefs.SetInt("Highscore34", PlayerPrefs.GetInt("Highscore33"));
                PlayerPrefs.SetInt("Highscore33", PlayerPrefs.GetInt("Highscore32"));
                PlayerPrefs.SetInt("Highscore32", instance.score);
            }
            else if (instance.score > PlayerPrefs.GetInt("Highscore33"))
            {
                PlayerPrefs.SetInt("Highscore35", PlayerPrefs.GetInt("Highscore34"));
                PlayerPrefs.SetInt("Highscore34", PlayerPrefs.GetInt("Highscore33"));
                PlayerPrefs.SetInt("Highscore33", instance.score);
            }
            else if (instance.score > PlayerPrefs.GetInt("Highscore34"))
            {
                PlayerPrefs.SetInt("Highscore35", PlayerPrefs.GetInt("Highscore34"));
                PlayerPrefs.SetInt("Highscore34", instance.score);
            }
            else if (instance.score > PlayerPrefs.GetInt("Highscore35"))
            {
                PlayerPrefs.SetInt("Highscore35", instance.score);
            }
        }
        else if (instance.currentLevelByInt == 4)
        {
            highscore1.text = PlayerPrefs.GetInt("Highscore41", 0).ToString();

            if (instance.score > PlayerPrefs.GetInt("Highscore41"))
            {
                PlayerPrefs.SetInt("Highscore45", PlayerPrefs.GetInt("Highscore44"));
                PlayerPrefs.SetInt("Highscore44", PlayerPrefs.GetInt("Highscore43"));
                PlayerPrefs.SetInt("Highscore43", PlayerPrefs.GetInt("Highscore42"));
                PlayerPrefs.SetInt("Highscore42", PlayerPrefs.GetInt("Highscore41"));
                PlayerPrefs.SetInt("Highscore41", instance.score);
                highscore1.text = instance.score.ToString();
            }
            else if (instance.score > PlayerPrefs.GetInt("Highscore42"))
            {
                PlayerPrefs.SetInt("Highscore45", PlayerPrefs.GetInt("Highscore44"));
                PlayerPrefs.SetInt("Highscore44", PlayerPrefs.GetInt("Highscore43"));
                PlayerPrefs.SetInt("Highscore43", PlayerPrefs.GetInt("Highscore42"));
                PlayerPrefs.SetInt("Highscore42", instance.score);
            }
            else if (instance.score > PlayerPrefs.GetInt("Highscore43"))
            {
                PlayerPrefs.SetInt("Highscore45", PlayerPrefs.GetInt("Highscore44"));
                PlayerPrefs.SetInt("Highscore44", PlayerPrefs.GetInt("Highscore43"));
                PlayerPrefs.SetInt("Highscore43", instance.score);
            }
            else if (instance.score > PlayerPrefs.GetInt("Highscore44"))
            {
                PlayerPrefs.SetInt("Highscore45", PlayerPrefs.GetInt("Highscore44"));
                PlayerPrefs.SetInt("Highscore44", instance.score);
            }
            else if (instance.score > PlayerPrefs.GetInt("Highscore45"))
            {
                PlayerPrefs.SetInt("Highscore45", instance.score);
            }

        }
    }

    public void PlayAgain(){

        instance.houseTutorialDone = false;
        instance.houseOneDone = false;
        instance.houseTwoDone = false;
        instance.houseThreeDone = false;
        instance.houseFourDone = false;
        instance.score = 0;
        if (instance.currentLevelByInt == 0 || instance.currentLevelByInt == 1)
        {
            instance.housesToVisit = 1;
            Timer.timer = 90;
        }
        else if (instance.currentLevelByInt == 2 || instance.currentLevelByInt == 3)
        {
            instance.housesToVisit = 2;
            Timer.timer = 120;
        }
        else {
            instance.housesToVisit = 3;
            Timer.timer = 150;
        }
    }
}
