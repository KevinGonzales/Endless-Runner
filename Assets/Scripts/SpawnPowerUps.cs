using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerUps : MonoBehaviour {

	public GameObject[] platform;
	public GameObject refrence; // the spawn point refrence
	Vector3 currentPosOffset = Vector3.zero;
	public float offset;

	// Use this for initialization
	void Start () {
		offset = 10f;
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void SpawnAPowerUp(){ //called to randomely spawn one
		Vector3 pos = new Vector3(refrence.transform.position.x,refrence.transform.position.y+1f,refrence.transform.position.z+offset);
		Instantiate (platform[Random.Range(0,4)], pos, transform.rotation);
	}
}
