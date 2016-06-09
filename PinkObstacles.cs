
using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PinkObstacles : MonoBehaviour
{
	//This script is attached to the pink fire obstacles and gives them a price of 3500 to distinguish
	//Once the fire is distinguished, a new area of the map is available and 4 new spawn points for enemies are instantiated
	//A message will appear on the screen with the price and will disappear when the player is far away or if the object is destroyed

	private GameObject player;
	private int cost = 3500;

	public Text console;

	public GameObject gm;



	// Use this for initialization
	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}

	// Update is called once per frame
	void Update()
	{

		if (Vector3.Distance(player.transform.position, this.transform.position) <= 15)
		{
			console.text = "Pay 3500 to extinguish.";

			if (Input.GetKeyDown(KeyCode.Space) && gm.GetComponent<GameMan>().getWallet() >= cost)
			{
				console.text = "";
				Destroy(this.gameObject);
				gm.GetComponent<GameMan>().purchaseItem(cost);
			}

		}
		else if (Vector3.Distance(player.transform.position, this.transform.position) <= 20)
		{
			console.text = "";

		}

	}

}
