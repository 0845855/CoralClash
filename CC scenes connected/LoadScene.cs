using UnityEngine;
using System.Collections;
//using UnityEditor.SceneManagement;

public class LoadScene : MonoBehaviour {

    public void LoadAbout()
    {
        Application.LoadLevel("about");
    }

    public void LoadMainMenu()
    {
        Application.LoadLevel("mainmenu");
    }

    public void LoadTutorial1()
    {
        Application.LoadLevel("tutorial");
    }

    public void LoadTutorial2()
    {
        Application.LoadLevel("tutorial2");
    }

    public void LoadTutorial3()
    {
        Application.LoadLevel("tutorial3");
    }

    public void LoadChooseTeam()
    {
        Application.LoadLevel("Team");
    }
}
