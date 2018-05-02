using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour {

    public Rigidbody2D rb;
    public float thrust;
    public float turnThrust;
    private float thrustInput;
    private float turnInput;
    public float screenLeft;
    public float screenRight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //thrust input
        thrustInput = Input.GetAxis ("Vertical");
        turnInput = Input.GetAxis ("Horizontal");

        //screen wrap
        Vector2 newPos = transform.position;
        if (transform.position.x > screenRight)
        {
            newPos.x = screenLeft;
        }
        if (transform.position.x < screenLeft)
        {
            newPos.x = screenRight;
        }
        transform.position = newPos;
    }

    private void FixedUpdate()
    {
        rb.AddRelativeForce (Vector2.up * thrustInput);
        rb.AddTorque (turnInput);
    }

}
