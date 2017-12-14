using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

    // Score for left player
    public static int scoreL = 0;
    // Score for right player
    public static int scoreR = 0;

    // Update left score
    void ScoreUpdaterLeftScript()
    {
        gameObject.GetComponent<ScoreUpdater>().updateLeft(scoreL);
    }
    // Update right score
    void ScoreUpdaterRightScript()
    {
        gameObject.GetComponent<ScoreUpdater>().updateRight(scoreR);
    }

    // Go to level loader once score is reached
    void LevelLoaderScript()
    {
        gameObject.GetComponent<LevelLoader>().startLevel();
    }

    // Set ball direction
    public float speed = 30;

    float onHit(Vector2 ballPos, Vector2 racketPos,
                float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight;
    }

    // SCRIPT FOR RACKET HITS
    void OnCollisionEnter2D(Collision2D col)
    {
        // Hit the left paddle?
        if (col.gameObject.name == "paddle1")
        {
            // Get position of hit
            float y = onHit(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction
            Vector2 dir = new Vector2(1, y).normalized;

            // Velocity
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        // Hit the right paddle?
        if (col.gameObject.name == "paddle2")
        {
            // Get position of hit
            float y = onHit(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction
            Vector2 dir = new Vector2(-1, y).normalized;

            // Velocity
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        // SCRIPT FOR BOUNDARIES
        if (col.gameObject.name == "ScoreBoundaryLeft")
        {
            scoreR++;
            ScoreUpdaterRightScript();

            int currentScene = SceneManager.GetActiveScene().buildIndex;

            // WHEN IN LEVEL 1:
            if (currentScene == 1)
            {
                if (scoreR == 5)
                {
                    LevelLoaderScript();
                }
            }

            //WHEN IN LEVEL 2:
            if (currentScene == 2)
            {
                if (scoreR == 10)
                {
                    LevelLoaderScript();
                }
            }

            //WHEN IN LEVEL 3:
            if (currentScene == 3)
            {
                if (scoreR == 15)
                {
                    LevelLoaderScript();
                }
            }
        }

        if (col.gameObject.name == "ScoreBoundaryRight")
        {
            scoreL++;
            ScoreUpdaterLeftScript();

            int currentScene = SceneManager.GetActiveScene().buildIndex;

            // WHEN IN LEVEL 1:
            if (currentScene == 1)
            {
                if (scoreL == 5)
                {
                    LevelLoaderScript();
                }
            }

            //WHEN IN LEVEL 2:
            if (currentScene == 2)
            {
                if (scoreL == 10)
                {
                    LevelLoaderScript();
                }
            }

            //WHEN IN LEVEL 3:
            if (currentScene == 3)
            {
                if (scoreL == 15)
                {
                    LevelLoaderScript();
                }
            }
        }

    }

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        // If spacebar is pressed
        if (Input.GetKeyDown("space"))
        {
            // Set starting velocity for ball
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        }
	}
}
