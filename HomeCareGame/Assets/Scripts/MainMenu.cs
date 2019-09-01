using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {
  GameObject GMobj;
  GameManager instance;

  void Awake(){
    GMobj = GameObject.Find("GameManager");
    instance = GMobj.GetComponent<GameManager>();

  }

    public void PlayGame() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void PlayGameAgain()
    {

        SceneManager.LoadScene(1);

    }
    public void BackToMainMenu()
    {

        SceneManager.LoadScene(0);

    }

    public void NextLevel()
    {

        SceneManager.LoadScene(3);

    }

    public void QuitGame() {  //siden disse er public får vi dem i on click

        Debug.Log("quit!"); //to make sure its working
        Application.Quit();   //if you build this and push the play button it will close down the program.
    }

}
