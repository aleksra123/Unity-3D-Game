using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;



public class ItemDropHandlerPills : MonoBehaviour, IDropHandler
{


    GameObject RedPill;
    GameObject BluePill;
    GameObject GreenPill;
    GameObject draggedItem;
    GameObject finalText;

    GameObject nextButton;
    GameObject GMobj;
    GameManager instance;

    public AudioClip correctDrop;
    public AudioClip dragnDropDone;
    public AudioSource audioSource;

    public int counter;
    public Text counterText;


    void Awake()
       {
   	GMobj=GameObject.Find("GameManager");
   	instance=GMobj.GetComponent<GameManager>();

   	}

    private void Start()
    {
        nextButton = GameObject.Find("NextButton");
        nextButton.SetActive(false);
        finalText = GameObject.Find("Final text");
        finalText.SetActive(false);
        RedPill = GameObject.Find("Pill1");
        BluePill = GameObject.Find("Pill2");
        GreenPill = GameObject.Find("Pill3");
        GMobj = GameObject.Find("GameManager");
        instance = GMobj.GetComponent<GameManager>();

    }
    private void Update()
    {
        counterText.text = "Counter: " + counter;
    }

    public void OnDrop(PointerEventData eventData)
    {
        draggedItem = eventData.pointerDrag;

        RectTransform invPanel = transform as RectTransform;
        Vector3 worldMouse = Input.mousePosition;
        worldMouse.z = 10;
        worldMouse = Camera.main.ScreenToWorldPoint(worldMouse);
        Vector3 ethan = GameObject.Find("PillHuman").transform.position;

        if (!RectTransformUtility.RectangleContainsScreenPoint(invPanel,
            Input.mousePosition))
        {
            if (worldMouse.y > ethan.y - 1.5 && worldMouse.y < ethan.y -1)
            {
                if (worldMouse.x > ethan.x - 1 && worldMouse.x < ethan.x + 1)
                {

//****************************************************************************************************************************

                  if(instance.houseNumberByInt==0){

                    if (draggedItem.name == "Pill1" && counter == 0)
                    {
                        counter++;
                        instance.score += 100;
                        audioSource.PlayOneShot(correctDrop);
                    }
                    else if (draggedItem.name == "Pill3" && (counter == 1 || counter == 2))
                    {
                        counter++;
                        instance.score += 100;
                        audioSource.PlayOneShot(correctDrop);
                    }
                    else if (draggedItem.name == "Pill2" && counter == 3)
                    {
                        counter++;
                        instance.score += 100;
                        audioSource.PlayOneShot(correctDrop);
                        audioSource.PlayOneShot(dragnDropDone);
                    }

}


//****************************************************************************************************************************

                if(instance.houseNumberByInt==1){

                    if (draggedItem.name == "Pill2" && counter == 0)
                    {
                        counter++;
                        instance.score += 100;
                        audioSource.PlayOneShot(correctDrop);
                    }
                    else if (draggedItem.name == "Pill1" && (counter == 1 || counter == 2))
                    {
                        counter++;
                        instance.score += 100;
                        audioSource.PlayOneShot(correctDrop);
                    }
                    else if (draggedItem.name == "Pill3" && counter == 3)
                    {
                        counter++;
                        instance.score += 100;
                        audioSource.PlayOneShot(correctDrop);
                        audioSource.PlayOneShot(dragnDropDone);
                    }

}

//****************************************************************************************************************************

                if(instance.houseNumberByInt==2){

                    if (draggedItem.name == "Pill3" && counter == 0)
                    {
                        counter++;
                        instance.score += 100;
                        audioSource.PlayOneShot(correctDrop);
                    }
                    else if (draggedItem.name == "Pill1" && (counter == 1 || counter == 2))
                    {
                        counter++;
                        instance.score += 100;
                        audioSource.PlayOneShot(correctDrop);
                    }
                    else if (draggedItem.name == "Pill3" && counter == 3)
                    {
                        counter++;
                        instance.score += 100;
                        audioSource.PlayOneShot(correctDrop);
                        audioSource.PlayOneShot(dragnDropDone);
                    }

}
//****************************************************************************************************************************

                if(instance.houseNumberByInt==3){

                    if (draggedItem.name == "Pill2" && counter == 0)
                    {
                        counter++;
                        instance.score += 100;
                        audioSource.PlayOneShot(correctDrop);
                    }
                    else if (draggedItem.name == "Pill1" && (counter == 1 || counter == 2))
                    {
                        counter++;
                        instance.score += 100;
                        audioSource.PlayOneShot(correctDrop);
                    }
                    else if (draggedItem.name == "Pill2" && counter == 3)
                    {
                        counter++;
                        instance.score += 100;
                        audioSource.PlayOneShot(correctDrop);
                        audioSource.PlayOneShot(dragnDropDone);
                    }

}
//****************************************************************************************************************************


                  if(instance.houseNumberByInt==4){

                    if (draggedItem.name == "Pill2" && counter == 0)
                    {
                        counter++;
                        instance.score += 100;
                        audioSource.PlayOneShot(correctDrop);
                    }
                    else if (draggedItem.name == "Pill1" && (counter == 1 || counter == 2))
                    {
                        counter++;
                        instance.score += 100;
                        audioSource.PlayOneShot(correctDrop);
                    }
                    else if (draggedItem.name == "Pill3" && counter == 3)
                    {
                        counter++;
                        instance.score += 100;
                        audioSource.PlayOneShot(correctDrop);
                        audioSource.PlayOneShot(dragnDropDone);
                    }

}



                }
                if (counter == 4)
                {
                    instance.score += 100;
                    nextButton.SetActive(true);
                    finalText.SetActive(true);
                }
            }
            else { counter = 0; }
        }
    }
}
