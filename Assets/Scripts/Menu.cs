using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {
    public void NewGame ()
    {
        Time.timeScale = 1;
        Application.LoadLevel(1);
    }

    public void Exit ()
    {
        Application.Quit();
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
