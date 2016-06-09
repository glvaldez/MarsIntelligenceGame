using UnityEngine;
using System.Collections;

public class PlayerH : MonoBehaviour {

	//The effects of whatever comes in contact with player are handled here
	//The Game Over screen appears because of this script
	//Commentary below

	private int health;

	private float timeAttacking;
	private float timerStart;
	private float timerEnd;

	public GameObject gm;
	public GameObject cs;
	public GameObject aud;



	public static bool GameOver = false;

	public GUIStyle labelStyle;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Blue"|| other.gameObject.tag == "Red" || other.gameObject.tag == "Green" || other.gameObject.tag == "Purple" || other.gameObject.tag == "Yellow" && Time.time > timerEnd)
		{
			gm.GetComponent<GameMan>().playOrbSound();
		}
		//Enemy hits the player and loses 10 health
		if (other.gameObject.tag == "Enemy" && Time.time > timerEnd)
		{
			gm.GetComponent<GameMan>().playerHitSound();
			cs.GetComponent<CharacterStat>().takeDamage(10);
		}
		//Flare hits the player and loses 10 health
		if (other.gameObject.tag == "Flare" && Time.time > timerEnd)
		{
			gm.GetComponent<GameMan>().playerHitSound();
			cs.GetComponent<CharacterStat>().takeDamage(10);
		}
		//Player grabs white health powerup and gains 10 health
		if (other.gameObject.tag == "Health1")
		{
			gm.GetComponent<GameMan>().playPowerupSound();
			cs.GetComponent<CharacterStat>().earnHealth(10);
			Destroy(other.gameObject);
		}
		//Player grabs max health powerup and health is restored
		if (other.gameObject.tag == "FullHealth")
		{
			gm.GetComponent<GameMan>().playOrbSound();
			cs.GetComponent<CharacterStat>().restoreHealth();
			Destroy(other.gameObject);
		}
		//DoublePts doesn't mean double points
		//It means if player grabs yellow dollar sign powerup, they gain 500 points
		if (other.gameObject.tag == "DoublePts")
		{
			gm.GetComponent<GameMan>().playPowerupSound();
			gm.GetComponent<GameMan>().wallet += 500;
			Destroy(other.gameObject);
		}
		//If player has 0 health or less, GameOver screen is active
		if (cs.GetComponent<CharacterStat>().getHealth() <= 0)
		{
			GameOver = true;
		}
		else
		{
			GameOver = false;
			//    gm.GetComponent<GameMan>().playerGameSound();
		}

	}

	void Start () {

		gm = GameObject.Find("GameManager");

	}

	// Update is called once per frame
	void Update()
	{

		if (GameOver==true)
		{
			//If the game is over, all activity freezes frame
			Time.timeScale = 0;
		}
		else
		{
			GameOver = false;
		}
	}
	void OnGUI()
	{
		//Once the game is over, all of the orb effects are reset

		if (GameOver == true)
		{
			
			Orb.yellowGrabbed = false;
			Orb.purpleGrabbed = false;
			Orb.greenGrabbed = false;
			Orb.redGrabbed = false;
			Orb.blueGrabbed = false;



			GUI.Label(new Rect((Screen.width/2)-150, 100, 300, 50), "GAME OVER", labelStyle);
			GUI.Label(new Rect((Screen.width/2)-150, 250, 300, 50), "Total Points: " + (GameMan.GamePoints), labelStyle);
            GUI.Label(new Rect((Screen.width / 2) - 150, 300, 300, 50), "Enemies Killed: " + (GameMan.GameEnemiesKilled), labelStyle);

            //If player wishes to play again, loads the game scene

            if (GUI.Button(new Rect((Screen.width/2)-150, 400, 300, 50), "Play Again"))
			{
				GameMan.GameShotsFired = 1;
				GameMan.GameEnemiesKilled = 0;
				GameMan.GamePoints = 0;
				GameOver = false;
				Time.timeScale = 1;
				Application.LoadLevel("Senior1");

			}
			//If player wishes to leave, loads the Main Menu scene

			if (GUI.Button(new Rect((Screen.width/2)-150, 500, 300, 50), "Exit"))
			{
				GameMan.GameShotsFired = 1;
				GameMan.GameEnemiesKilled = 0;
				GameMan.GamePoints = 0;
				GameOver = false;
				Time.timeScale = 1;
				Application.LoadLevel("SeniorMM");
			}
		}
	}
}

