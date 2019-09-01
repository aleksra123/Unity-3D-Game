using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;




public class ItemDropHandler : MonoBehaviour, IDropHandler
{
    GameObject boxers;
    GameObject pants;
    GameObject shirt;
    GameObject draggedItem;
    GameObject nextButton;
    GameObject GMobj;
    GameManager instance;


    private void Start()
    {
        pants = GameObject.Find("pants");
        pants.SetActive(false);
        boxers = GameObject.Find("underwear");
        boxers.SetActive(false);
        shirt = GameObject.Find("shirt");
        shirt.SetActive(false);
        nextButton = GameObject.Find("NextButton");
        nextButton.SetActive(false); 
        GMobj = GameObject.Find("GameManager");
        instance = GMobj.GetComponent<GameManager>();
    }


    public void OnDrop(PointerEventData eventData)
    {

        draggedItem = eventData.pointerDrag;

        RectTransform invPanel = transform as RectTransform;
        Vector3 worldMouse = Input.mousePosition;
        worldMouse.z = 10;
        worldMouse = Camera.main.ScreenToWorldPoint(worldMouse);
        Vector3 ethan = GameObject.Find("DressHuman").transform.position;

        if (!RectTransformUtility.RectangleContainsScreenPoint(invPanel,
            Input.mousePosition))
        {
            if (worldMouse.y > ethan.y && worldMouse.y < ethan.y + 2)
            {
                if (worldMouse.x > ethan.x - 1 && worldMouse.x < ethan.x + 1)
                {
                    if (draggedItem.name == "tshirtImg")
                    {
                        shirt.SetActive(true);
                        instance.score += 100;
                    }
                }
            }

            if (worldMouse.y > ethan.y && worldMouse.y < ethan.y + 2)
            {
                if (worldMouse.x > ethan.x - 1 && worldMouse.x < ethan.x + 1)
                {
                    if (draggedItem.name == "underwearImg")
                    {
                        boxers.SetActive(true);
                        instance.score += 100;
                        if (!shirt.activeSelf && !pants.activeSelf){
                            instance.score += 50;
                        }
                    }
                    else if (draggedItem.name == "pantsImg")
                    {
                        pants.SetActive(true);
                        instance.score += 100;
                        if(!boxers.activeSelf){
                            instance.score -= 50;
                        }
                    }
                }
            }
        }

        if (shirt.activeSelf && pants.activeSelf && boxers.activeSelf)
        {
            nextButton.SetActive(true);
            instance.score += 100;
        }

    }
}
