using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void LoadGame()
    {
        Application.LoadLevel("Senior1");
    }
    public void LoadMM()
    {
        Application.LoadLevel("SeniorMM");
    }
    public void LoadInstructions()
    {
        Application.LoadLevel("SeniorInstructions");
    }
	public void ExitGame()
	{
		Application.Quit();
	}
}
