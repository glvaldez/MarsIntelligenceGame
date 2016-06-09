using UnityEngine;
using System.Collections;

public class Cameras : MonoBehaviour {

    public GameObject player;
    public GameObject planet;

    public int cameraAngle = 0;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.C))
        {
            transform.Rotate(Vector3.up, 90, Space.Self);
            cameraAngle++;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.Rotate(Vector3.up, -90, Space.Self);
            cameraAngle--;
        }
        if (cameraAngle % 4 == 0)
        {
            planet.SetActive(true);
        }
        else
        {
            planet.SetActive(false);
        }
    }
}
