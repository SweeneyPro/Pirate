using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Angle : MonoBehaviour {

    public int boatAngle;

    [SerializeField]
    private ShipBehaviour m_boat;

	// Use this for initialization
	void Start () {

        
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void IncreaseAngle(int num)
    {
        boatAngle += num;
        UpdateUI(boatAngle);
    }

    public void DecreaseAngle(int num)
    {
        boatAngle -= num;
        UpdateUI(boatAngle);
    }

    private void UpdateUI(int num)
    {
        gameObject.GetComponent<Text>().text = "Angle: " + num.ToString();
        m_boat.SetBoatAngle(boatAngle);
    }
}
