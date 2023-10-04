using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{

    //  drag and drop connection through unity
    public GameObject gameManager;
    //  the script
    private GameManager gm;
    public GameObject gameOverMenu;


    // Start is called before the first frame update
    void Start()
    {
        gm = gameManager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.getGameOver() == true)
        {
            showGameOverMenu();
        }
    }


    public void showGameOverMenu()
    {

        gameOverMenu.SetActive(true);
    
    }

    public void exitGame()
    {

        Application.Quit();

    }    

    public void restartGame()
    {
        gm.setGameOver(false);
        gameOverMenu.SetActive(false);
        SceneManager.LoadScene("SampleScene");

    }

}
