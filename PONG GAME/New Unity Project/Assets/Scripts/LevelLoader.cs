using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

    public void startLevel() // This function starts on start button click and once player scores are reached
    {
        // The following line gets the current scene's ID
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        if (currentScene == 0) // 0 refers to the Menu level ID.
        {
            SceneManager.LoadScene(1); // Load first level via level ID
        }

        // The following if statements are called when the scores are reached. 
        // They check if the current level is either level 1, 2, or 3.

        else if (currentScene == 1) // If score reached and current scene is level1
        {
            SceneManager.LoadScene(2); // Load level 2
        }

        else if (currentScene == 2) // If score reached and current scene is level2
        {
            SceneManager.LoadScene(3); // Load level 3
        }

        else if (currentScene == 3) // If final score reached and current scene is level 3
        {
            SceneManager.LoadScene(4); // Load winner screen
        }
    }
	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
