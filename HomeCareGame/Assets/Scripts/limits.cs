using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limits : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        var myPosX = transform.position.x;
        var myPosY = transform.position.y;
        var myPosZ = transform.position.z;

        //Debug.Log("x: " + myPosX + " / z: " + myPosZ);

        if (myPosZ <= -15)
        {
            transform.position = new Vector3(myPosX, myPosY, -15);
        }
    }

}
