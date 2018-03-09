using UnityEngine;
using System.Collections;

public class CharacterStat : MonoBehaviour {

    private int health;

    public GameObject gm;

    public GameObject health80;
    public GameObject health70;
    public GameObject health60;
    public GameObject health50;
    public GameObject health40;
    public GameObject health30;
    public GameObject health20;
    public GameObject health10;
    
    // Use this for initialization
    void Start () {
        this.health = 40;
    }

    // Update is called once per frame
    void Update () {
        if (Orb.blueGrabbed == true){
            if (this.health == 80){
                health80.SetActive(true);
                health70.SetActive(true);
                health60.SetActive(true);
                health50.SetActive(true);
                health40.SetActive(true);
                health30.SetActive(true);
                health20.SetActive(true);
                health10.SetActive(true);
            }
            else if (this.health == 70){
                health80.SetActive(false);
                health70.SetActive(true);
                health60.SetActive(true);
                health50.SetActive(true);
                health40.SetActive(true);
                health30.SetActive(true);
                health20.SetActive(true);
                health10.SetActive(true);
            }
            else if (this.health == 60){
                health80.SetActive(false);
                health70.SetActive(false);
                health60.SetActive(true);
                health50.SetActive(true);
                health40.SetActive(true);
                health30.SetActive(true);
                health20.SetActive(true);
                health10.SetActive(true);
            }
            else if (this.health == 50){
                health80.SetActive(false);
                health70.SetActive(false);
                health60.SetActive(false);
                health50.SetActive(true);
                health40.SetActive(true);
                health30.SetActive(true);
                health20.SetActive(true);
                health10.SetActive(true);
            }
        }
        if (this.health == 40){
            health80.SetActive(false);
            health70.SetActive(false);
            health60.SetActive(false);
            health50.SetActive(false);
            health40.SetActive(true);
            health30.SetActive(true);
            health20.SetActive(true);
            health10.SetActive(true);
        }
        else if (this.health == 30){
            health80.SetActive(false);
            health70.SetActive(false);
            health60.SetActive(false);
            health50.SetActive(false);
            health40.SetActive(false);
            health30.SetActive(true);
            health20.SetActive(true);
            health10.SetActive(true);
        }
        else if (this.health == 20){
            health80.SetActive(false);
            health70.SetActive(false);
            health60.SetActive(false);
            health50.SetActive(false);
            health40.SetActive(false);
            health30.SetActive(false);
            health20.SetActive(true);
            health10.SetActive(true);
        }
        else if (this.health == 10){
            health80.SetActive(false);
            health70.SetActive(false);
            health60.SetActive(false);
            health50.SetActive(false);
            health40.SetActive(false);
            health30.SetActive(false);
            health20.SetActive(false);
            health10.SetActive(true);
        }
        else if (this.health == 0){
            health80.SetActive(false);
            health70.SetActive(false);
            health60.SetActive(false);
            health50.SetActive(false);
            health40.SetActive(false);
            health30.SetActive(false);
            health20.SetActive(false);
            health10.SetActive(false);
        }
    }

    public int getHealth(){
        return this.health;
    }

    public void takeDamage(int damageTaken){
        this.health -= damageTaken;
    }
    public void earnHealth(int healthEarned){
        if (Orb.blueGrabbed == true){
            if (this.health < 80){
                this.health += healthEarned;
            }
        }
        else {
            if (this.health < 40){
                this.health += healthEarned;
            }
        }
    }

    public void restoreHealth()
    {
        if (Orb.blueGrabbed == true){
            this.health = 80;
        }
        else {
            this.health = 40;
        }
    }
}
