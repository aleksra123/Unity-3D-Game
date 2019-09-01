using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ItemDragHandler : MonoBehaviour, IDragHandler, IEndDragHandler {
//her må du sette det bilde du vil bruke aktivt, hvert bilde må ha dette scriptet på seg.
  public GameObject squash;
  public GameObject potatoes;
  public GameObject aubergine;

  GameObject GMobj;
  GameManager instance;


    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.localPosition = Vector3.zero;
    }

    void Awake(){
      GMobj = GameObject.Find("GameManager");
      instance = GMobj.GetComponent<GameManager>();

    }

    void Start(){

      	if(instance.houseNumberByInt==1){
            squash.SetActive(true);
            potatoes.SetActive(false);
            aubergine.SetActive(false);



        }
        if(instance.houseNumberByInt==2){
            squash.SetActive(false);
            potatoes.SetActive(false);
            aubergine.SetActive(true);

        }
    }
}
