using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

    public GameObject gm;

    private GameObject health1;

    public float health = 3;


    // Use this for initialization
    void Start () {
        health1 = GameObject.FindGameObjectWithTag("Health1");
        gm = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update () {
        if (health <= 0)
        {
            gm.GetComponent<GameMan>().enemyDies();
            Destroy(this.gameObject);


            //     playerSource.PlayOneShot(aud.GetComponent<Audio>().zombie3, 0.1f);
            if (GameMan.isLast == true && Orb.purpleGrabbed==true)
            {
                GameObject Health = GameObject.Instantiate(health1, this.transform.position, this.transform.rotation) as GameObject;
                Powerups.powerupCounter = 1;
            }
        }
    }
}
