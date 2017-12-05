using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetection : MonoBehaviour{
	public Vector3 RespawnPosition;
	public GameObject HurtOverlay;

	void Awake() {
		RespawnPosition = new Vector3 (-4.289f, -16.148f, 0);
	}
	void OnTriggerEnter2D (Collider2D other)
	{
		other.transform.position = RespawnPosition;
		HurtOverlay.GetComponent<Image>().CrossFadeAlpha(220, .01f, false);
		HurtOverlay.GetComponent<Image>().CrossFadeAlpha(1, .5f, false);
	}
}