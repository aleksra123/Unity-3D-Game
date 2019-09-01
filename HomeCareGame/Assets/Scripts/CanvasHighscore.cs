using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasHighscore : MonoBehaviour {

    public Text highscore11, highscore12, highscore13, highscore14, highscore15;
    public Text highscore21, highscore22, highscore23, highscore24, highscore25;
    public Text highscore31, highscore32, highscore33, highscore34, highscore35;
    public Text highscore41, highscore42, highscore43, highscore44, highscore45;
   




    void Start () {
        highscore11.text = PlayerPrefs.GetInt("Highscore11", 0).ToString();
        highscore12.text = PlayerPrefs.GetInt("Highscore12", 0).ToString();
        highscore13.text = PlayerPrefs.GetInt("Highscore13", 0).ToString();
        highscore14.text = PlayerPrefs.GetInt("Highscore14", 0).ToString();
        highscore15.text = PlayerPrefs.GetInt("Highscore15", 0).ToString();

        highscore21.text = PlayerPrefs.GetInt("Highscore21", 0).ToString();
        highscore22.text = PlayerPrefs.GetInt("Highscore22", 0).ToString();
        highscore23.text = PlayerPrefs.GetInt("Highscore23", 0).ToString();
        highscore24.text = PlayerPrefs.GetInt("Highscore24", 0).ToString();
        highscore25.text = PlayerPrefs.GetInt("Highscore25", 0).ToString();

        highscore31.text = PlayerPrefs.GetInt("Highscore31", 0).ToString();
        highscore32.text = PlayerPrefs.GetInt("Highscore32", 0).ToString();
        highscore33.text = PlayerPrefs.GetInt("Highscore33", 0).ToString();
        highscore34.text = PlayerPrefs.GetInt("Highscore34", 0).ToString();
        highscore35.text = PlayerPrefs.GetInt("Highscore35", 0).ToString();

        highscore41.text = PlayerPrefs.GetInt("Highscore41", 0).ToString();
        highscore42.text = PlayerPrefs.GetInt("Highscore42", 0).ToString();
        highscore43.text = PlayerPrefs.GetInt("Highscore43", 0).ToString();
        highscore44.text = PlayerPrefs.GetInt("Highscore44", 0).ToString();
        highscore45.text = PlayerPrefs.GetInt("Highscore45", 0).ToString();

    }

    public void ResetHighscore()
    {
        PlayerPrefs.DeleteAll();
        highscore11.text = "0";
        highscore12.text = "0";
        highscore13.text = "0";
        highscore14.text = "0";
        highscore15.text = "0";

        highscore21.text = "0";
        highscore22.text = "0";
        highscore23.text = "0";
        highscore24.text = "0";
        highscore25.text = "0";

        highscore31.text = "0";
        highscore32.text = "0";
        highscore33.text = "0";
        highscore34.text = "0";
        highscore35.text = "0";

        highscore41.text = "0";
        highscore42.text = "0";
        highscore43.text = "0";
        highscore44.text = "0";
        highscore45.text = "0";

    }


}
