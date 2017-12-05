using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopClock : MonoBehaviour {
	public GameObject clock;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) {
		clock.GetComponent<Timer>().enabled = false;
			
	}
}
