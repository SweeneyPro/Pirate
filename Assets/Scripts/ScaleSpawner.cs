using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleSpawner : MonoBehaviour {

    [SerializeField]
    private GameObject m_scaleArt;

    public int widthAxisCount, heightAxisCount;

    [SerializeField]
    private float offset;

    // Use this for initialization
    void Start () {

        for (int i = 0; i < widthAxisCount; i++)
        {
            Instantiate(m_scaleArt, new Vector3(i * offset + 0.65f, 0,-0.15f), Quaternion.Euler(new Vector3(90, 0, 0)));
        }

        for (int i = 0; i < heightAxisCount; i++)
        {
            Instantiate(m_scaleArt, new Vector3(-0.15f, 0, i * offset + 0.4f), Quaternion.Euler(new Vector3(90, 0, -90)));
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
