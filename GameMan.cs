using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameMan : MonoBehaviour {

    //Total enemies per round (Increments as round increases)
    private int totalEnemiesRound = 8;
    //Active enemies at one time (Increments as round increases)     
    private int maxEnemies = 3;
    //Enemies killed each round
    public int enemiesKilled = 0;
    //Out of a tota of..
    public int enemiesSpawnedInRound = 0;
    
    public int wallet = 0;
    public Text walletText;


    public Transform[] enemySpawnLocations;
    private int maxArraySize;
    public GameObject Enemy;
    public GameObject Player;

    public static bool isLast = false;

    public int round = 1;

    public Text roundText;
    public Text console;

    // public GameObject gun;


    private AudioSource source;
    public AudioClip buySomething;
    public AudioClip laserAud;
    public AudioClip laserHit;
    public AudioClip powerup;
    public AudioClip orb;
    public AudioClip nextRound;
    public AudioClip takeDamage;
    public AudioClip Game1;


    public GameObject laser;
    public GameObject opening1;
    private GameObject health1;
	public GameObject Sun;

    public Transform s36;
    public Transform s37;
    public Transform s38;
    public Transform s39;
    public Transform s40;
    public Transform s41;
    public Transform s42;
    public Transform s43;
    public Transform s44;
    public Transform s45;
    public Transform s46;
    public Transform s47;
    public Transform s48;
    public Transform s49;
    public Transform s50;
    public Transform s51;
    public Transform s52;
    public Transform s53;
    public Transform s54;
    public Transform s55;
    public Transform s56;
    public Transform s57;
    public Transform s58;
    public Transform s59;
    public Transform s60;
    public Transform s61;
    public Transform s62;
    public Transform s63;
    public Transform s64;
    public Transform s65;
    public Transform s66;
    public Transform s67;
    public Transform s68;
    public Transform s69;
    public Transform s70;
    public Transform s71;
    public Transform s72;
    public Transform s73;
    public Transform s74;
    public Transform s75;
    public Transform s76;
    public Transform s77;
    public Transform s78;
    public Transform s79;
    public Transform s80;
    public Transform s81;
    public Transform s82;
    public Transform s83;
    public Transform s84;
    public Transform s85;
    public Transform s86;
    public Transform s87;
    public Transform s88;
    public Transform s89;
    public Transform s90;
    public Transform s91;
    public Transform s92;
    public Transform s93;
    public Transform s94;
    public Transform s95;
    public Transform s96;
    public Transform s97;
    public Transform s98;
    public Transform s99;
    public Transform s100;

    //  public GameObject cloakUI;
    // public GameObject cloakPanelUI;
    // public GameObject doublePointsUI;

    private float laserTimerAlive;
    private float laserTimerStart;
    private float laserTimerEnd;

    public static int GamePoints = 500;
    public static int GameRound = 1;
    public static int GameEnemiesKilled = 0;
    public static int GameShotsFired = 1;

    //   public GameObject healthRestoreUI;


    // Use this for initialization
    void Start() {
        maxArraySize = 4;

        health1 = GameObject.FindGameObjectWithTag("Health1");
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
		Debug.Log(enemiesSpawnedInRound);
		Debug.Log(maxEnemies);
		Debug.Log(enemiesKilled);
		Debug.Log(totalEnemiesRound);

        walletText.text = "" + wallet;

        //Each round has a max number of enemies to spawn.  The round will continue to spawn enemies until the max is reached.
        //For example, if there were 8 enemies needed to be killed to complete the round and the player already killed 7, only 1 enemy will
        //remain active on the field rather than the maxEnemies of 3.  Once the last enemy is killed, the round increments and a bunch of new
        //enemies will spawn at once

        //total==32
        //max==11
        //killed
        if (Orb.yellowGrabbed == true && Orb.purpleGrabbed == true && Orb.greenGrabbed == true && Orb.redGrabbed == true && Orb.blueGrabbed == true)
        {
            Sun.SetActive(false);

            changeArraySize(100);
            enemySpawnLocations[35] = s36;
            enemySpawnLocations[36] = s37;
            enemySpawnLocations[37] = s38;
            enemySpawnLocations[38] = s39;
            enemySpawnLocations[39] = s40;
            enemySpawnLocations[40] = s41;
            enemySpawnLocations[41] = s42;
            enemySpawnLocations[42] = s43;
            enemySpawnLocations[43] = s44;
            enemySpawnLocations[44] = s45;
            enemySpawnLocations[45] = s46;
            enemySpawnLocations[46] = s47;
            enemySpawnLocations[47] = s48;
            enemySpawnLocations[48] = s49;
            enemySpawnLocations[49] = s50;
            enemySpawnLocations[50] = s51;
            enemySpawnLocations[51] = s52;
            enemySpawnLocations[52] = s53;
            enemySpawnLocations[53] = s54;
            enemySpawnLocations[54] = s55;
            enemySpawnLocations[55] = s56;
            enemySpawnLocations[56] = s57;
            enemySpawnLocations[57] = s58;
            enemySpawnLocations[58] = s59;
            enemySpawnLocations[59] = s60;
            enemySpawnLocations[60] = s61;
            enemySpawnLocations[61] = s62;
            enemySpawnLocations[62] = s63;
            enemySpawnLocations[63] = s64;
            enemySpawnLocations[64] = s65;
            enemySpawnLocations[65] = s66;
            enemySpawnLocations[66] = s67;
            enemySpawnLocations[67] = s68;
            enemySpawnLocations[68] = s69;
            enemySpawnLocations[69] = s70;
            enemySpawnLocations[70] = s71;
            enemySpawnLocations[71] = s72;
            enemySpawnLocations[72] = s73;
            enemySpawnLocations[73] = s74;
            enemySpawnLocations[74] = s75;
            enemySpawnLocations[75] = s76;
            enemySpawnLocations[76] = s77;
            enemySpawnLocations[77] = s78;
            enemySpawnLocations[78] = s79;
            enemySpawnLocations[79] = s80;
            enemySpawnLocations[80] = s81;
            enemySpawnLocations[81] = s82;
            enemySpawnLocations[82] = s83;
            enemySpawnLocations[83] = s84;
            enemySpawnLocations[84] = s85;
            enemySpawnLocations[85] = s86;
            enemySpawnLocations[86] = s87;
            enemySpawnLocations[87] = s88;
            enemySpawnLocations[88] = s89;
            enemySpawnLocations[89] = s90;
            enemySpawnLocations[90] = s91;
            enemySpawnLocations[91] = s92;
            enemySpawnLocations[92] = s93;
            enemySpawnLocations[93] = s94;
            enemySpawnLocations[94] = s95;
            enemySpawnLocations[95] = s96;
            enemySpawnLocations[96] = s97;
            enemySpawnLocations[97] = s98;
            enemySpawnLocations[98] = s99;
            enemySpawnLocations[99] = s100;

        }

        if (enemiesSpawnedInRound < maxEnemies && (enemiesKilled+maxEnemies)<= totalEnemiesRound)
        {
            SpawnEnemy();
        }
        //Every round, the last enemy who dies will spawn a health
        if (totalEnemiesRound == enemiesKilled+1 && round%1==0)
        {
            isLast = true;

        }
        else
        {
            isLast = false;
        }
        //If the user killed as many enemies as required to complete the round, increment the round and reset the enemiesKilled counter.
        //The total number of enemies active on the field at one time will now increment to 4 and the round will now require you to kill 11
        //enemies instead of 8.
        if (enemiesKilled >= totalEnemiesRound)
        {
            source.PlayOneShot(nextRound, 1.0f);
            round++;
            GameRound++;
            roundText.text = "" + round;

            totalEnemiesRound += 2;
            maxEnemies+=2;

            enemiesKilled = 0;
            
        }
        //If the yellow orb was grabbed, the laser will be instantiated

        if (Orb.yellowGrabbed == true)
        {
            if (Input.GetMouseButton(0) && Time.time > laserTimerEnd)
            {
                //   ammo--;
                source.PlayOneShot(laserAud, 0.2f);
                laserTimerStart = Time.time;
                laserTimerEnd = laserTimerStart + laserTimerAlive;

                GameObject pistolBullet = GameObject.Instantiate(laser, opening1.transform.position, opening1.transform.rotation) as GameObject;
                pistolBullet.GetComponent<Rigidbody>().velocity = this.opening1.transform.TransformDirection(new Vector3(0, 0, 100));

            }
        }

    }
    
    public void enemyDies(){
        source.PlayOneShot(laserHit, 0.5f);
        
		if (Orb.greenGrabbed == true) {
			this.wallet += 75;
			GamePoints += 75;
		} else {
			this.wallet += 50;
			GamePoints += 50;
		}

        this.enemiesKilled++;
        GameEnemiesKilled++;
        this.enemiesSpawnedInRound--;
    }
    //Spawns an enemy in a random location near the vicinity of the player
    void SpawnEnemy()
    {
        Vector3 randomSpawnPoint = enemySpawnLocations[Random.Range(0, maxArraySize)].position;
        while (Vector3.Distance(Player.transform.position, randomSpawnPoint)>200)
        {
            randomSpawnPoint = enemySpawnLocations[Random.Range(0, maxArraySize)].position;
        }
        GameObject.Instantiate(Enemy, randomSpawnPoint, Quaternion.identity);
   
        this.enemiesSpawnedInRound++;

    }
    public void playPowerupSound()
    {
        source.PlayOneShot(powerup, 1.0f);
    }
    public void playOrbSound()
    {
        source.PlayOneShot(orb, 1.0f);
    }
    public void playerHitSound()
    {
        source.PlayOneShot(takeDamage, 1.0f);
    }
    public void playerGameSound()
    {
        source.PlayOneShot(Game1, 1.0f);
    }
    public void purchaseItem(int cost)
    {
        source.PlayOneShot(buySomething, 1.0f);
        this.wallet -= cost;
    }
    public int getWallet()
    {
        return this.wallet;
    }
    public void changeArraySize(int i)
    {
        this.maxArraySize = i;
    }
    public int getMaxArraySize()
    {
        return this.maxArraySize;
    }
    public int getTotalEnemiesInRound()
    {
        return this.totalEnemiesRound;
    }
}

