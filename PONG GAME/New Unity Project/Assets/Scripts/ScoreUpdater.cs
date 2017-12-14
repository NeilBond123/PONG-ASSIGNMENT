using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour {
    public Text displayL;
    public Text displayR;

    // Used to display score needed to win the game
    public static int winScore = 5;

    public void updateLeft(int scoreL)
    {
        // If left player's score is 5
        if (scoreL == 5)
        {
            // If winScore IS NOT ALREADY AT 10
            if (winScore != 10)
            {
                // Set level 2 win score
                winScore += 5;
            }
        }

        // If left player's score is 10
        else if (scoreL == 10)
        {
            // If winScore IS NOT ALREADY AT 15
            if (winScore != 15)
            {
                // Set level 2 win score
                winScore += 5;
            }
        }

        //  Finally display left player's score and level's win score
        displayL.text = "Score Left: " + scoreL.ToString() + "/" +winScore;
    }

    public void updateRight(int scoreR)
    {
        // If right player's score is 5
        if (scoreR == 5)
        {
            // If winScore IS NOT ALREADY AT 10
            if (winScore != 10)
            {
                // Set level 2 win score
                winScore += 5;
            }
        }

        // If right player's score is 10
        else if (scoreR == 10)
        {
            // If winScore IS NOT ALREADY AT 15
            if (winScore != 15)
            {
                // Set level 2 win score
                winScore += 5;
            }
        }

        // Finally display right player's score and level's win score
        displayR.text = "Score Right: " + scoreR.ToString() + "/" + winScore; 
    }

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
