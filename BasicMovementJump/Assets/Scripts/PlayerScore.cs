using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//  attached to player
public class PlayerScore : MonoBehaviour
{

    private int playerScore;
    public TMP_Text guiScore;

    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
    }

    

    public int getScore()
    {
        return playerScore;
    }

    public void setPlayerScore(int val)
    {
        playerScore += val;
        guiScore.text = playerScore.ToString();
        Debug.Log("Player Score: " + playerScore);
    }


}
