using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float speed = 30;

    float onHit(Vector2 ballPos, Vector2 racketPos,
                float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight;
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        // Hit the left Racket?
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

        // Right paddle
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
