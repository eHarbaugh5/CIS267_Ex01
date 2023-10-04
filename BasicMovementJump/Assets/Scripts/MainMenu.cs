using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void loadGame()
    {

        SceneManager.LoadScene("SampleScene");

    }

    public void exitGame()
    {
        // this only works with a builld of the game. It will not work when playing the game in the Unity editor
        Application.Quit();

    }
}
