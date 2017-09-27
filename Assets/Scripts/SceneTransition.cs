using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class SceneTransition : MonoBehaviour {

	// Use this for initialization
	void Start () {

        if(this.gameObject.GetComponent<Button>() == null)
        {
            Debug.LogError("You didn't pick a button action");
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
 
    public void MainMenuScene()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void GameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    
}
