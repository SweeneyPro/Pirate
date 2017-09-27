using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipBehaviour : MonoBehaviour {



    // Use this for initialization
    void Start () {

     
		
	}
	
	// Update is called once per frame
	void Update () {
		
        
	}

    public void SetBoatAngle(int angle)
    {
        transform.parent.rotation = Quaternion.Euler(new Vector3(transform.parent.rotation.x, angle, transform.parent.rotation.z));
    }
}
