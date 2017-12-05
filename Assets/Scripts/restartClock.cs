using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restartClock : MonoBehaviour {
	public GameObject clock;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) {
		clock.GetComponent<Timer> ().storedTime = Time.time;
		clock.GetComponent<Timer>().enabled = true;

	}
}
