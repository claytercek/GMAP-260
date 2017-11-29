using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetection : MonoBehaviour
{
	public GameObject HurtOverlay;

	void OnTriggerEnter2D (Collider2D other)
	{
		other.transform.position = new Vector3(-4.289f, -16.148f, 0);
		HurtOverlay.GetComponent<Image>().CrossFadeAlpha(220, .01f, false);
		HurtOverlay.GetComponent<Image>().CrossFadeAlpha(1, .5f, false);
	}
}