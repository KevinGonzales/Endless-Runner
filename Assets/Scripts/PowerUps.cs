using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PowerUps : MonoBehaviour {

	//whenever that is activated your next jump iss hiegher

	static bool jumpHiegher;	//jump hiegher for one jump
	static bool lowerTime;		//less time but 3 seconds
	static bool moveSlower;		//lower your speed by .1f




	// Use this for initialization
	void Start () {
		jumpHiegher = false;
		lowerTime = false;
		moveSlower = false;
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter (Collision col)
	{
		Debug.Log ("in");

		if(col.gameObject.tag == "JumpPower")
		{
			jumpHiegher = true;
			Destroy (col.gameObject);
		}
		if(col.gameObject.tag == "TimerPower")
		{
			lowerTime = true;
			Destroy (col.gameObject);
		}
		if(col.gameObject.tag == "MovePower")
		{
			moveSlower = true;
			Destroy (col.gameObject);
		}
		if(col.gameObject.tag == "LostPower")
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

	public bool getPowerUpJump(){
		return jumpHiegher;
	}

	public void setPowerUpJump(bool powerUp){
		jumpHiegher = powerUp;
	}

	public bool getPowerUpTime(){
		return lowerTime;
	}

	public void setPoweupTime(bool powerUp){
		lowerTime = powerUp;
	}

	public bool getPowerUpMove(){
		return moveSlower;
	}

	public void setPoweupMove(bool powerUp){
		moveSlower = powerUp;
	}
}
