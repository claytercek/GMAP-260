using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
	void OnTriggerEnter2D (Collider2D other)
	{
		other.transform.position = new Vector3(-4, -16, 0);
	}
}