using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityStandardAssets.Vehicles.Car;
using UnityStandardAssets.Characters.FirstPerson;

public class Player_Network : NetworkBehaviour 
{

    public GameObject Car_Camera;
   
    public override void OnStartLocalPlayer()
    {
        GetComponent<CarController>().enabled = true;
        Car_Camera.SetActive(true);   



    }
}
