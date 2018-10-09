using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouFell : MonoBehaviour {

	static bool lost = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (gameObject.transform.position.y < -25f) {
			lost = true;
		}
	}

	public bool getLost(){
		return lost;
	}

	public void setLost(bool bo){
		lost = bo;
	}
}
