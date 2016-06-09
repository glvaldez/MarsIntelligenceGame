using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class OrangeObstacles : MonoBehaviour
{

    private GameObject player;
    private int cost = 1500;

    public Text console;

    public GameObject gm;

    public Transform s9;
    public Transform s10;
    public Transform s11;
    public Transform s12;
    
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
            console.text = "Pay 1500 to extinguish.";

            if (Input.GetKeyDown(KeyCode.Space) && gm.GetComponent<GameMan>().getWallet() >= cost)
            {
                console.text = "";
                Destroy(this.gameObject);
                gm.GetComponent<GameMan>().purchaseItem(cost);
                gm.GetComponent<GameMan>().changeArraySize(12);
                gm.GetComponent<GameMan>().enemySpawnLocations[8] = s9;
                gm.GetComponent<GameMan>().enemySpawnLocations[9] = s10;
                gm.GetComponent<GameMan>().enemySpawnLocations[10] = s11;
                gm.GetComponent<GameMan>().enemySpawnLocations[11] = s12;

            }
        

        }
        else if(Vector3.Distance(player.transform.position, this.transform.position)<=20)
        {
            console.text = "";

        }

    }
        
}
