using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour
{
	//Everything concerning the laser is handled in this script
	//The green orb allows the player to shoot further
	//If the laser comes in contact with a powerup, the powerup is grabbed
	//If the laser hits an enemy, it will destroy it
	//ORIGINAL PLAN: To increase the enemy health as rounds increase, thus the enemy health decrement rather than just destroying the object

	private float timeAlive;
	private float timerStart;
	private float timerEnd;

	public GameObject zh;
	public GameObject cs;
	public GameObject gm;

	private AudioSource source;
	public AudioClip laserHit;
	public AudioClip powerup;
	public AudioClip orb;

	// Use this for initialization
	void Start()
	{
		source = GetComponent<AudioSource>();

		gm = GameObject.Find("GameManager");
		cs = GameObject.Find("PlayerManager");
		GameMan.GameShotsFired++;

		if (Orb.greenGrabbed == true)
		{
			timeAlive = .35f;
		}
		else
		{
			timeAlive = .25f;
		}
		timerStart = Time.time;
		timerEnd = timerStart + timeAlive;

	}

	// Update is called once per frame
	void Update()
	{
		if (Time.time > timerEnd)
		{
			Destroy(this.gameObject);
		}


	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			Destroy(this.gameObject);
			//Was supposed to decrease to 2 after a certain number of rounds, changed mind
			other.GetComponent<EnemyHealth>().health -= 3;

		}
		if (other.gameObject.tag == "Health1")
		{
			gm.GetComponent<GameMan>().playPowerupSound();

			cs.GetComponent<CharacterStat>().earnHealth(10);
			Destroy(other.gameObject);
		}
		if (other.gameObject.tag == "FullHealth")
		{
			gm.GetComponent<GameMan>().playOrbSound();
			cs.GetComponent<CharacterStat>().restoreHealth();
			Destroy(other.gameObject);
		}
		if (other.gameObject.tag == "DoublePts")
		{
			gm.GetComponent<GameMan>().playPowerupSound();
			gm.GetComponent<GameMan>().wallet += 500;
			Destroy(other.gameObject);
		}
	}
}