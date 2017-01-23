using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChooseTeam : MonoBehaviour {

	public GameStatus gs;

	public void TeamRed(){
		// gs.TeamColor = 1;
		Application.LoadLevel("map");
	}

	public void TeamBlue(){
		// gs.TeamColor = 2;
		Application.LoadLevel("map");
	}






	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
