using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoint1 : MonoBehaviour{
	public Vector3 startPosition;
	public Sprite GreenSwitch;
	// Use this for initialization
	void Start () {
		startPosition = new Vector3 (-4.289f, -16.148f, 0);
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) {
		gameObject.GetComponent<SpriteRenderer> ().sprite = GreenSwitch;
		foreach(GameObject spikes in GameObject.FindGameObjectsWithTag("obstacle"))
		{
			spikes.GetComponent<CollisionDetection> ().RespawnPosition = startPosition;
		}
	}
}
