using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{

    public int scoreRed = 0;
    public int scoreRed1 = 0;
    public int scoreRed2 = 0;
    public int scoreRed3 = 0;

    public int scoreBlue = 0;
    public int scoreBlue1 = 0;
    public int scoreBlue2 = 0;
    public int scoreBlue3 = 0;


    // Update is called once per frame
    void Update()
    {

        GameObject go = GameObject.Find("GameStatus");
        if (go == null)
        {
            Debug.LogError("Failed to find an object named 'GameStatus");
            this.enabled = false;
            return;
        }
        GameStatus gs = go.GetComponent<GameStatus>();

        // Team rood - score berekening
        if (gs.claimed1 == 1)
        {
            scoreRed1 = 1;
        }
        if (gs.claimed2 == 1)
        {
            scoreRed2 = 1;
        }
        if (gs.claimed3 == 1)
        {
            scoreRed3 = 1;
        }

        // Team blauw - score berekening
        if (gs.claimed1 == 2)
        {
            scoreBlue1 = 1;
        }
        if (gs.claimed2 == 2)
        {
            scoreBlue2 = 1;
        }
        if (gs.claimed3 == 2)
        {
            scoreBlue3 = 1;
        }

        scoreBlue = scoreBlue1 + scoreBlue2 + scoreBlue3;
        scoreRed = scoreRed1 + scoreRed2 + scoreRed3;

        GetComponent<Text>().text = "Blauw: " + scoreBlue + " - " + "Rood: " + scoreRed + "   (" + "Zone " + gs.zone + ")";

        /*GameObject go = GameObject.Find("GameStatus");
        if (go == null)
        {
            Debug.LogError("Failed to find an object named 'GameStatus");
            this.enabled = false;
            return;
        }
        GameStatus gs = go.GetComponent<GameStatus>();

        GetComponent<Text>().text = "Score: " + gs.score + " " + "Lives: " + gs.numLives + " " + "Zone:" + " " + gs.zone;*/

    }
}
