using UnityEngine;
using System.Collections;

public class Orb : MonoBehaviour {

    public GameObject gm;
    public GameObject cs;

    public GameObject yellow;
    public GameObject purple;
    public GameObject green;
    public GameObject red;
    public GameObject blue;

    public static bool yellowGrabbed=false;
    public static bool purpleGrabbed = false;
    public static bool greenGrabbed = false;
    public static bool redGrabbed = false;
    public static bool blueGrabbed = false;

    public GameObject yellowOrb;
    public GameObject purpleOrb;
    public GameObject greenOrb;
    public GameObject redOrb;
    public GameObject blueOrb;

    public Transform s5;
    public Transform s6;
    public Transform s7;
    public Transform s8;

    public GameObject Money1;
    public GameObject Money2;
    public GameObject Money3;
    public GameObject Money4;
    public GameObject Money5;
    public GameObject Money6;
    public GameObject Money7;
    public GameObject Money8;
    public GameObject Money9;
    public GameObject Money10;
    
    // Use this for initialization
    void Start()
    {
		gm = GameObject.Find("GameManager");

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        //Laser is enabled
        if (other.gameObject.tag == "Yellow")
        {
			gm.GetComponent<GameMan>().wallet += 100;
			GameMan.GamePoints += 100;
            yellow.SetActive(true);
            Destroy(yellowOrb);
            yellowGrabbed = true;
            gm.GetComponent<GameMan>().changeArraySize(8);
            gm.GetComponent<GameMan>().enemySpawnLocations[4] = s5;
            gm.GetComponent<GameMan>().enemySpawnLocations[5] = s6;
            gm.GetComponent<GameMan>().enemySpawnLocations[6] = s7;
            gm.GetComponent<GameMan>().enemySpawnLocations[7] = s8;
        }
        //Powerups are enabled in game play
        if (other.gameObject.tag == "Purple")
        {
			gm.GetComponent<GameMan>().wallet += 100;
			GameMan.GamePoints += 100;
            purple.SetActive(true);
            Destroy(purpleOrb);
            purpleGrabbed = true;
            cs.GetComponent<CharacterStat>().restoreHealth();
            Money1.SetActive(true);
            Money2.SetActive(true);
            Money3.SetActive(true);
            Money4.SetActive(true);
            Money5.SetActive(true);
            Money6.SetActive(true);
            Money7.SetActive(true);
            Money8.SetActive(true);
            Money9.SetActive(true);
            Money10.SetActive(true);
        }
        //Laser is capable of reaching further distances, and fire rate increases
        if (other.gameObject.tag == "Green")
        {
			gm.GetComponent<GameMan>().wallet += 100;
			GameMan.GamePoints += 100;
            green.SetActive(true);
            Destroy(greenOrb);
            greenGrabbed = true;
        }
        //Allows player to build bridges in select locations of map.  A red galaxy prefab will appear in these locations
        if (other.gameObject.tag == "Red")
        {
			gm.GetComponent<GameMan>().wallet += 100;
			GameMan.GamePoints += 100;
            red.SetActive(true);
            Destroy(redOrb);
            redGrabbed = true;

        }
        //Player has 4 more health
        if (other.gameObject.tag == "Blue")
        {
			gm.GetComponent<GameMan>().wallet += 100;
			GameMan.GamePoints += 100;
            blue.SetActive(true);
            Destroy(blueOrb);
            blueGrabbed = true;
            cs.GetComponent<CharacterStat>().restoreHealth();
        }
    }

}
