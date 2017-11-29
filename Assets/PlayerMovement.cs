using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public int playerSpeed = 1;
    public bool flipped = false;
    public float moveX;
	private Animator animator;
	private float initialScalex;
	private float moveDirection;

	// Update is called once per frame
	void Awake () {
		animator = GetComponent<Animator>();
		initialScalex = transform.localScale.x;
	}
	void Update () {
        PlayerMove();
		if (Input.GetKeyDown ("right") || Input.GetKeyDown ("left")) {
			animator.SetBool ("Move", true);
		}
		if (Input.GetKeyUp ("right") || Input.GetKeyUp ("left")) {
			animator.SetBool ("Move", false);
		}

		moveDirection = Mathf.Ceil (Input.GetAxis ("Horizontal"));
		if (Input.GetKeyDown ("right")) {
			moveDirection = 1;
		}
		if (Input.GetKeyDown ("left")) {
			moveDirection = -1;
		}
		if (moveDirection != 0) {
			transform.localScale = new Vector3(moveDirection*initialScalex, transform.localScale.y, transform.localScale.z);
		}


	}


    void PlayerMove()
    {
		if (Input.GetKeyDown("space"))
        {
            flipGravity();

        }
        float moveX = Input.GetAxis("Horizontal");
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

