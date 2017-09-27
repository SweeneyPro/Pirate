using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GridSpawn : MonoBehaviour {

    [SerializeField]
    private LineRenderer m_lineRenderer;

    private Vector3 m_targetPos;

	// Use this for initialization
	void Start () {
        m_targetPos = new Vector3(transform.localPosition.x, transform.localPosition.y * 50, transform.localPosition.z);
		
	}
	
	// Update is called once per frame
	void Update () {

        m_lineRenderer.SetPosition(0, transform.position);
        m_lineRenderer.SetPosition(1, transform.position + transform.right * 100);
	}
}
