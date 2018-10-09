using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepOnPlatform : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnControllerColliderHit(ControllerColliderHit other)
	{
		if (other.gameObject.tag.Equals ("Platform")) {
			other.gameObject.GetComponent<DestroyAtDistance>().SetPlayerStepped (true);
		}
	}
}
