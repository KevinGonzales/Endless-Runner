using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Spawn : MonoBehaviour {

	YouFell youFell = new YouFell();

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		bool temp = youFell.getLost ();
		if (temp == true) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			youFell.setLost (false);
		}
	}
}
