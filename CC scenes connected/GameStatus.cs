using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameStatus : MonoBehaviour {

	static GameStatus TheRealGameStatus;

	// public SwitchClick switchClick;
	// public ZoneSwitch zoneSwitch;

	public int zone;
	public int currColor;
	public int TeamColor;
	public int newColor;
	
	public Color red;
	public Color blue;

	void start(){
		if(TheRealGameStatus != null){
			Destroy(this.gameObject);
			return;
		}
		TheRealGameStatus = this;
		GameObject.DontDestroyOnLoad(this);
	}

	void update(){
		// zone = zoneSwitch.zone;
		// currColor = zoneSwitch.currColor;
		// newColor = switchClick.newColor;
		print("Doorsturen Zone " + zone);
		print("Doorsturen Team " + TeamColor);
	}
}