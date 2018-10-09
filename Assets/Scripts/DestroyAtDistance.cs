using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAtDistance : MonoBehaviour {

	public float distance = 100;
	bool playerStepped = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//are we far away nough from the camera?
		if((Vector3.Distance(Camera.main.transform.position,transform.position)>distance) && playerStepped){
			Destroy (gameObject);
		}
	}

	public void SetPlayerStepped(bool step){
		playerStepped = true;
	}
}
