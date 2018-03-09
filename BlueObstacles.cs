using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BlueObstacles : MonoBehaviour {
    private GameObject player;
    private int cost = 5000;

    public Text console;

    public GameObject gm;
    
    public Transform s31;
    public Transform s32;
    public Transform s33;
    public Transform s34;
    public Transform s35;

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
            console.text = "Pay 5000 to extinguish.";
            if (Input.GetKeyDown(KeyCode.Space) && gm.GetComponent<GameMan>().getWallet() >= cost)
            {
                console.text = "";
                Destroy(this.gameObject);
                gm.GetComponent<GameMan>().purchaseItem(cost);
                gm.GetComponent<GameMan>().changeArraySize(35);
                gm.GetComponent<GameMan>().enemySpawnLocations[30] = s31;
                gm.GetComponent<GameMan>().enemySpawnLocations[31] = s32;
                gm.GetComponent<GameMan>().enemySpawnLocations[32] = s33;
                gm.GetComponent<GameMan>().enemySpawnLocations[33] = s34;
                gm.GetComponent<GameMan>().enemySpawnLocations[34] = s35;
            }
        }
        else if (Vector3.Distance(player.transform.position, this.transform.position) <= 20)
        {
            console.text = "";
        }

    }

}
