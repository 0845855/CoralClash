using UnityEngine;
using UnityEngine.UI;

using System.Collections;
#pragma strict;

public class SwitchClick : MonoBehaviour {

private GameObject clonekoraalRood;
private GameObject clonekoraalBlauw;
    private int clickCount = 1;
        public int newColor = 0;
	public GameObject pijpkoraal; 
    public GameObject KoraalTeamRood;
    public GameStatus gameStatus;

    private int modelNumber;

	// Use this for initialization
	void Start () {
        clonekoraalBlauw = (GameObject)Instantiate(pijpkoraal, new Vector3(-0.15f , -0.04f, 0), Quaternion.identity);
	}

    public void SwitchModel(){

              if(clickCount == 1){
                  print("Switch 1");
                  clonekoraalRood = (GameObject)Instantiate(KoraalTeamRood, new Vector3(0 , 0, 0), Quaternion.identity);
                  clonekoraalRood.transform.parent = GameObject.Find("Marker").transform;
                  Destroy(clonekoraalBlauw);
                  clickCount = 2;
                  newColor = 1;
              }
              else if(clickCount == 2){
                  print("Switch 2");
				  clonekoraalBlauw = (GameObject)Instantiate(pijpkoraal, new Vector3(-0.15f , -0.04f, 0), Quaternion.identity);
                  clonekoraalBlauw.transform.parent = GameObject.Find("Marker").transform;
                  Destroy(clonekoraalRood);	 
                  clickCount = 1;
                  newColor = 2;
              }
    }
	
	// Update is called once per frame
	// void Update () {
	//     if (Input.GetKeyDown(KeyCode.Space)){ 

    //           if(clickCount == 1){
    //               print("Switch 1");
    //               clonekoraalRood = (GameObject)Instantiate(KoraalTeamRood, new Vector3(0 , 0, 0), Quaternion.identity);
    //               clonekoraalRood.transform.parent = GameObject.Find("Marker").transform;
    //               Destroy(clonekoraalBlauw);
    //               clickCount = 2;
    //           }
    //           else if(clickCount == 2){
    //               print("Switch 2");
	// 			  clonekoraalBlauw = (GameObject)Instantiate(pijpkoraal, new Vector3(-0.15f , -0.04f, 0), Quaternion.identity);
    //               clonekoraalBlauw.transform.parent = GameObject.Find("Marker").transform;
    //               Destroy(clonekoraalRood);	 
    //               clickCount = 1;
    //           }
    //       }
    //  }
}

