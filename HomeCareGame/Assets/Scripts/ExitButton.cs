using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{

    public void ExitGame()
    {

        SceneManager.LoadScene("MainMenu");

    }

    public void PlayGameAgain()
    {

        SceneManager.LoadScene("DrivingCar1");

    }

    public void QuitGame()
    {  //siden disse er public får vi dem i on click 

        Debug.Log("quit!"); //to make sure its working
        Application.Quit();   //if you build this and push the play button it will close down the program. 
    }

}

