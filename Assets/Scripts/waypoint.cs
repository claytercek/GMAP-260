using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoint : MonoBehaviour{
	public Vector3 waypointPosition;
	public Sprite GreenSwitch;
	// Use this for initialization
	void Start () {
		waypointPosition = transform.position;
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) {
		gameObject.GetComponent<SpriteRenderer> ().sprite = GreenSwitch;
		foreach(GameObject spikes in GameObject.FindGameObjectsWithTag("obstacle"))
		{
			spikes.GetComponent<CollisionDetection> ().RespawnPosition = waypointPosition;
		}
	}
}
