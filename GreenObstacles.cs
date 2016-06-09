using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GreenObstacles : MonoBehaviour
{

    private GameObject player;
    private int cost = 2500;

    public Text console;

    public GameObject gm;

    public Transform s13;
    public Transform s14;
    public Transform s15;
    public Transform s16;
    public Transform s17;
    public Transform s18;
    public Transform s19;
    public Transform s20;
    public Transform s21;
    public Transform s22;
    public Transform s23;
    public Transform s24;
    public Transform s25;
    public Transform s26;
    public Transform s27;
    public Transform s28;
    public Transform s29;
    public Transform s30;


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
            console.text = "Pay 2500 to extinguish.";

            if (Input.GetKeyDown(KeyCode.Space) && gm.GetComponent<GameMan>().getWallet() >= cost)
            {
                console.text = "";
                Destroy(this.gameObject);
                gm.GetComponent<GameMan>().purchaseItem(cost);
                gm.GetComponent<GameMan>().changeArraySize(30);
                gm.GetComponent<GameMan>().enemySpawnLocations[12] = s13;
                gm.GetComponent<GameMan>().enemySpawnLocations[13] = s14;
                gm.GetComponent<GameMan>().enemySpawnLocations[14] = s15;
                gm.GetComponent<GameMan>().enemySpawnLocations[15] = s16;
                gm.GetComponent<GameMan>().enemySpawnLocations[16] = s17;
                gm.GetComponent<GameMan>().enemySpawnLocations[17] = s18;
                gm.GetComponent<GameMan>().enemySpawnLocations[18] = s19;
                gm.GetComponent<GameMan>().enemySpawnLocations[19] = s20;
                gm.GetComponent<GameMan>().enemySpawnLocations[20] = s21;
                gm.GetComponent<GameMan>().enemySpawnLocations[21] = s22;
                gm.GetComponent<GameMan>().enemySpawnLocations[22] = s23;
                gm.GetComponent<GameMan>().enemySpawnLocations[23] = s24;
                gm.GetComponent<GameMan>().enemySpawnLocations[24] = s25;
                gm.GetComponent<GameMan>().enemySpawnLocations[25] = s26;
                gm.GetComponent<GameMan>().enemySpawnLocations[26] = s27;
                gm.GetComponent<GameMan>().enemySpawnLocations[27] = s28;
                gm.GetComponent<GameMan>().enemySpawnLocations[28] = s29;
                gm.GetComponent<GameMan>().enemySpawnLocations[29] = s30;


            }

        }
        else if(Vector3.Distance(player.transform.position, this.transform.position)<=20)
        {
            console.text = "";

        }

    }

}
