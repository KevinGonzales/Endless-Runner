using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	public GameObject[] platform;
	Vector3 currentPosOffset = Vector3.zero;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Instantiate (platform[Random.Range(0,2)], currentPosOffset, transform.rotation);
		currentPosOffset += new Vector3 (Random.Range(-3,3), Random.Range(-2,2),Random.Range(15,16));
	}
}