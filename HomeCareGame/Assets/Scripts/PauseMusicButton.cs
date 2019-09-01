using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMusicButton : MonoBehaviour {
    public Button m_PauseBGMusic;
    private bool paused;
    public Sprite diasblemusic;
    public Sprite PlayMusic;
    // Use this for initialization
    void Start()
    {
        m_PauseBGMusic.onClick.AddListener(TaskOnClick);
        paused = false;
    }

    void TaskOnClick()
    {
        if (paused == false)
        {
            AudioSource source1 = GameObject.FindGameObjectWithTag("BackgroundMusic").GetComponent<AudioSource>();
            source1.Pause();
            paused = true;
            m_PauseBGMusic.image.overrideSprite = diasblemusic;
        }
        else
        {
            AudioSource source1 = GameObject.FindGameObjectWithTag("BackgroundMusic").GetComponent<AudioSource>();
            source1.Play(0);
            paused = false;
            m_PauseBGMusic.image.overrideSprite = PlayMusic;
        }

    }
}
