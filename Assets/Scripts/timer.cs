using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour {
	float timeLeft = 30.0f;
	public Text text;
	public Text win;
	PowerUps powerUp = new PowerUps();
	public SpawnPowerUps spawnPowerUps ;


	// Use this for initialization
	void Start () {
		
	}

	void Update()
	{
		int makePowerUp = Random.Range (0,100);
		if(makePowerUp ==0){
			spawnPowerUps.SpawnAPowerUp ();
		}

		text.text = "" + timeLeft;

		bool temp = powerUp.getPowerUpTime();
		if (temp) {	//if powerUp was grabed
			timeLeft -= 3f;
			powerUp.setPoweupTime (false);
		} else {
			timeLeft -= Time.deltaTime;
		}

		if(timeLeft < 0)
		{
			text.text = "";
			win.text = "You WIN!!!";
		}

		if(timeLeft < -2){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}

	}
		

}
