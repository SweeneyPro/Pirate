using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class HeaderSpawn : MonoBehaviour {

    [SerializeField]
    private GameObject m_headerArt;

    public int widthAxisCount, heightAxisCount;

	// Use this for initialization
	void Start () {
		
        for (int i = 0; i < widthAxisCount; i++)
        {
            Instantiate(m_headerArt, new Vector3(i, 0, 0), Quaternion.Euler(new Vector3(90,0,0)));
        }

        for (int i = 0; i < heightAxisCount; i++)
        {
            Instantiate(m_headerArt, new Vector3(0, 0, i), Quaternion.Euler(new Vector3(90, 0, -90)));
        }
	}
	
	// Update is called once per frame
	void Update () {

    }
}
