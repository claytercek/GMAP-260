using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public int playerSpeed = 1;
    public bool flipped = false;
    public float moveX;

	// Update is called once per frame
	void Update () {
        PlayerMove();	
	}
    void PlayerMove()
    {
        if (Input.GetKeyDown("space"))
        {
            flipGravity();
        }
        moveX = Input.GetAxis("Horizontal");
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2((moveX * playerSpeed)/2, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }
    void flipGravity()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity.Set(0, 0);
        flipped = !flipped;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.y *= -1;
        transform.localScale = localScale;
        Physics2D.gravity = Physics2D.gravity * -1;
        gameObject.GetComponent<Rigidbody2D>().velocity.Set(0, 0);
    }
}

