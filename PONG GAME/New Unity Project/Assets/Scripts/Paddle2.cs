using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2 : MonoBehaviour {
    public float speed = 30;

    void FixedUpdate()
    {
        float v = Input.GetAxis("Mouse Y");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
        
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
     
	}
}
