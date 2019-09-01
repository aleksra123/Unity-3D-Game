using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;




public class ItemDropHandlerFood : MonoBehaviour, IDropHandler
{
    GameObject chicken;
    GameObject carrot;
    GameObject potatoe;
    GameObject squash;
    public GameObject aubergine;
    GameObject draggedItem;

    GameObject mycasserole;
    GameObject GMobj;
    GameManager instance;


    private void Start()
    {
        chicken = GameObject.Find("chicken");
        squash = GameObject.Find("Squash");
        squash.SetActive(false);
        chicken.SetActive(false);
        carrot = GameObject.Find("carrots");
        carrot.SetActive(false);
        potatoe = GameObject.Find("potatoes");
        potatoe.SetActive(false);
        aubergine.SetActive(false);

        mycasserole = GameObject.Find("casserole");

    }


    public void OnDrop(PointerEventData eventData)
    {

        draggedItem = eventData.pointerDrag;

        RectTransform invPanel = transform as RectTransform;
        Vector3 worldMouse = Input.mousePosition;
        worldMouse.z = 10;
        worldMouse = Camera.main.ScreenToWorldPoint(worldMouse);
        Vector3 pan = GameObject.Find("pan").transform.position;
        Vector3 casserole = GameObject.Find("casserole").transform.position;


        if (!RectTransformUtility.RectangleContainsScreenPoint(invPanel,
            Input.mousePosition))
        {
            if (worldMouse.y > pan.y -3.5 -0.5 && worldMouse.y < pan.y - 3.5 +0.5)
            {

                if (worldMouse.z > pan.z + 1.9 -1 && worldMouse.z < pan.z + 1.9 +1 )
                {

                    if (draggedItem.name == "chickenImg") //dette er selve kyllingen i pannen
                    {
                        chicken.SetActive(true);
                    }
                }
            }
            if (worldMouse.y > casserole.y - 4.9 -1 && worldMouse.y < casserole.y - 4.9 +1)
            {
                if (worldMouse.z > casserole.z - 1 -1 && worldMouse.z < casserole.z - 1 +1)
                {

                    if (draggedItem.name == "potatoesImg")
                    {
                        potatoe.SetActive(true);
                        mycasserole.GetComponent<AudioSource>().Stop();

                    }
                    if (draggedItem.name =="carrotsImg")
                    {
                        carrot.SetActive(true);
                          mycasserole.GetComponent<AudioSource>().Stop();
                    }
                    if (draggedItem.name =="squashImg")
                    {
                        squash.SetActive(true);
                          mycasserole.GetComponent<AudioSource>().Stop();
                    }
                    if (draggedItem.name =="aubergineImg")
                    {
                        aubergine.SetActive(true);
                          mycasserole.GetComponent<AudioSource>().Stop();
                    }
                }
            }
        }


    }
}
