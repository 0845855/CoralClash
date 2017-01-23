using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ZoneSwitch : MonoBehaviour {

	public Button zone1;
	public int currColor;
	public Color red;
	public Color blue;
	// public int zone;

	GameStatus gs;

	// public GameObject GO_gameStatus;
	// public GameStatus gameStatus;


		// Update is called once per frame
public	void Update () {
		GameObject go =  GameObject.Find("GameStatus");
		if(go == null){
			Debug.LogError("Failed to find an object named 'GameStatus'");
			this.enabled = false;
			return;
		}

		GameStatus gs = go.GetComponent<GameStatus>();

		if(gs.newColor == 1){
			Button b = zone1.GetComponent<Button>(); 
 			ColorBlock cb = b.colors;
 			cb.normalColor = Color.red;
 			b.colors = cb;
			 currColor =gs.newColor;

			// GetComponent<Button>().colors.normalColor = Color.red;
		}
		if(gs.newColor == 2){
			Button b = zone1.GetComponent<Button>(); 
 			ColorBlock cb = b.colors;
 			cb.normalColor = Color.blue;
 			b.colors = cb;
			currColor = gs.newColor;
		}
	}

	public void ARviewZone1(){
		// gs.zone = 1;

		if(GetComponent<Button>().colors.normalColor == red){
			currColor = 1;
		}
		else if(GetComponent<Button>().colors.normalColor == blue){
			currColor = 2;
		}
		else{
			currColor = 0;
		}
		print("Color" + currColor);
		// print("Zone" + gs.zone);

		SceneManager.LoadScene("ARview");
	}

	public void ARviewZone2(){
		// gs.zone = 2;

		if(GetComponent<Button>().colors.normalColor == red){
			currColor = 1;
		}
		else if(GetComponent<Button>().colors.normalColor == blue){
			currColor = 2;
		}
		else{
			currColor = 0;
		}
		print("Color" + currColor);
		// print("Zone" + gs.zone);

		SceneManager.LoadScene("ARview");
	}

	public void ARviewZone3(){
		// gs.zone = 3;

		if(GetComponent<Button>().colors.normalColor == red){
			currColor = 1;
		}
		else if(GetComponent<Button>().colors.normalColor == blue){
			currColor = 2;
		}
		else{
			currColor = 0;
		}
		print("Color" + currColor);
		// print("Zone" + gs.zone);

		SceneManager.LoadScene("ARview");
	}

	public void MapSwitch(){

		SceneManager.LoadScene("map");
	}
}