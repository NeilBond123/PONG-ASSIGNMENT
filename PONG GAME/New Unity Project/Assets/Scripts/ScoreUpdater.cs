using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour {
    public Text scoreUpdater;

    public void updateLeft(int scoreL, int scoreR)
    {
        scoreUpdater.text = "Score Left: " + scoreL.ToString() + "Score Right: " + scoreR.ToString();
    }

    public void updateRight(int scoreL, int scoreR)
    {
        scoreUpdater.text = "Score Left: " + scoreL.ToString() + "Score Right: " + scoreR.ToString();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
