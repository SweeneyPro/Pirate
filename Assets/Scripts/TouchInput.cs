using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour {

    [SerializeField]
    private GameObject m_block;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            GetMousePosition();
        }
        
	}

    void GetMousePosition()
    {
        Vector3 pos = Input.mousePosition;
        pos = Camera.main.ScreenToWorldPoint(pos);
        CheckCoordinate(pos);
    }

    void CheckCoordinate (Vector3 posVector)
    {
        if(posVector.x < 0 || posVector.y < 0 || posVector.z < 0)
        {
            Debug.LogError("MOUSE CLICK IS OFF THE MAP");
            return;
        }

        Instantiate(m_block, new Vector3(Mathf.RoundToInt(posVector.x), 0, (Mathf.RoundToInt(posVector.z))), Quaternion.identity);

    }


}
